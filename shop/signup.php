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
<div id="block-content-reg">
<?php

	$data = $_POST;

	function captcha_show(){
		$questions = array(
			1 => '������� ������',
			2 => '������� ���',
			3 => '2 + 3',
			4 => '15 + 14',
			5 => '45 - 10',
			6 => '33 - 3'
		);
		$num = mt_rand( 1, count($questions) );
		$_SESSION['captcha'] = $num;
		echo $questions[$num];
	}

	//���� �������� �� button
	if ( isset($data['do_signup']) )
	{
    // �������� ����� �� ������� �����
		$errors = array();
		if ( trim($data['login']) == '' )
		{
			$errors[] = '������� �����';
		}

		if ( trim($data['email']) == '' )
		{
			$errors[] = '������� Email';
		}

		if ( $data['password'] == '' )
		{
			$errors[] = '������� ������';
		}

		if ( $data['password_2'] != $data['password'] )
		{
			$errors[] = '��������� ������ ������ �� �����!';
		}

		//�������� �� ������������� ����������� ������
		if ( R::count('users', "login = ?", array($data['login'])) > 0)
		{
			$errors[] = '������������ � ����� ������� ��� ����������!';
		}
    
    //�������� �� ������������� ����������� email
		if ( R::count('users', "email = ?", array($data['email'])) > 0)
		{
			$errors[] = '������������ � ����� Email ��� ����������!';
		}

		//�������� �����
		$answers = array(
			1 => '������',
			2 => '���������',
			3 => '5',
			4 => '29',
			5 => '35',
			6 => '30'
		);
		if ( $_SESSION['captcha'] != array_search( mb_strtolower($_POST['captcha']), $answers ) )
		{
			$errors[] = '����� �� ������ ������ �� �����!';
		}


		if ( empty($errors) )
		{
			//������ ���, ������ ������������
			$user = R::dispense('users');
			$user->login = $data['login'];
			$user->email = $data['email'];
			$user->password = password_hash($data['password'], PASSWORD_DEFAULT); //������ ������ ������� � �������� ����, �� ��� ������� ��� ������ ������� password_hash ��� php > 5.6
			R::store($user);
			echo '<div style="color:green;">�� ������� ����������������!</div><hr>';
		}else
		{
			echo '<div id="errors" style="color:red;">' .array_shift($errors). '</div><hr>';
		}

	}

?>

<form action="signup.php" method="POST">
	<strong>��� �����</strong>
	<input type="text" name="login" value="<?php echo @$data['login']; ?>"><br/>

	<strong>��� Email</strong>
	<input type="email" name="email" value="<?php echo @$data['email']; ?>"><br/>

	<strong>��� ������</strong>
	<input type="password" name="password" value="<?php echo @$data['password']; ?>"><br/>

	<strong>��������� ������</strong>
	<input type="password" name="password_2" value="<?php echo @$data['password_2']; ?>"><br/>

	<strong>����� : <?php captcha_show(); ?></strong>
	<input type="text" name="captcha" ><br/>

	<button type="submit" name="do_signup">�����������</button>
</form>
</div>

<?php
require 'include/block-footer.php';
?>
</div>
</body>
</html>
