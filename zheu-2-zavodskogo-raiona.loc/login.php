<?
require_once "C:\OSPanel\domains\zheu-2-zavodskogo-raiona.loc\config.php";
//������ ������;
session_start();

if (isset($_POST['login']) && isset($_POST['password']))
{
// �������� ������ �� ����� � ������������
$login = mysql_real_escape_string($_POST['login']);
$password = $_POST['password'];
//�������� ������ � ������
if (($login=='admin')&& ($password=='123123')){
echo '<script>location.replace("administrator.php");</script>';
$_SESSION['Name']=$login;
// ���� �� �������� ��� ��������������� ������������
}

else
{die('����� ����� � ������� �� ������� � ���� ������.');
}
}
?>
