<?
require_once "C:\OSPanel\domains\zheu-2-zavodskogo-raiona.loc\config.php";
//Запуск сессий;
session_start();

if (isset($_POST['login']) && isset($_POST['password']))
{
// получаем данные из формы с авторизацией
$login = mysql_real_escape_string($_POST['login']);
$password = $_POST['password'];
//проверка пароля и логина
if (($login=='admin')&& ($password=='123123')){
echo '<script>location.replace("administrator.php");</script>';
$_SESSION['Name']=$login;
// идем на страницу для авторизованного пользователя
}

else
{die('Такой логин с паролем не найдены в базе данных.');
}
}
?>
