<?php
ob_start();
print_r("<html>
<head>
    <meta http-equiv=\"content-type\" content=\"text/html; charset=windows-1251\" />
    <link href=\"css/style.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"css/reset.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"https://fonts.googleapis.com/css?family=Russo+One\" rel=\"stylesheet\">
    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css\" integrity=\"sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4\" crossorigin=\"anonymous\">
    <link href=\"css/style-category.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\">
    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>
    <script src=\"bootstrap/js/bootstrap.min.js\"></script>
    <script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>
    <style>
    </style>
</head>
<body>
<div id=\"block-body\">");
?>
<?php
require 'db.php';
?>
<?php
require_once("include/block-header.php");
?>
<div id="block-content-login">
<?php


	$data = $_POST;
	if ( isset($data['do_login']) )
	{
		$user = R::findOne('users', 'login = ?', array($data['login']));
		if ( $user )
		{
			//логин существует
			if ( password_verify($data['password'], $user->password) )
			{
				//если пароль совпадает, то нужно авторизовать пользователя
				$_SESSION['logged_user'] = $user;
                header ('Location: index.php');  // перенаправление на нужную страницу
                exit();    // прерываем работу скрипта, чтобы забыл о прошлом
			}else
			{
				$errors[] = 'Неверно введен пароль!';
			}

		}else
		{
			$errors[] = 'Пользователь с таким логином не найден!';
		}
		
		if ( ! empty($errors) )
		{
			//выводим ошибки авторизации
			echo '<div id="errors" style="color:red;">' .array_shift($errors). '</div><hr>';
		}

	}

?>


<form action="login.php" method="POST">
	<strong>Логин</strong>
	<input type="text" name="login" value="<?php echo @$data['login']; ?>"><br/>

	<strong>Пароль</strong>
	<input type="password" name="password" value="<?php echo @$data['password']; ?>"><br/>

	<button type="submit" name="do_login">Войти</button>
</form>
</div>

<?php
require 'include/block-footer.php';
?>
</div>
</body>
</html>
