<?php
$hostname_connect = "localhost";
$database_connect = "DataBase";
$username_connect = "root";
$password_connect = "";

$connect = mysql_pconnect($hostname_connect,$username_connect,$password_connect) or trigger_error(mysql_error(),E_USER_ERROR);
mysql_select_db($database_connect);
//����� ������ � ���������
@mysql_query("set character_set_client='utf8'");
@mysql_query("set character_set_result='utf8'");
@mysql_query("set character_set_connection='utf8'");
//----------------------code DataBase-----------------//
// ���������� � �����
$name = $_POST['name'];
$firstname = $_POST['firstname'];
$lastname = $_POST['lastname'];
$phone = $_POST['phone'];
$street = $_POST['street'];
$corpus = $_POST['corpus'];
$home = $_POST['home'];
$float = $_POST['float'];
$massage = $_POST['massage'];
//������ ������ � ���������� � ���� ������
$result = mysql_query ("INSERT INTO `orderfeedback` (`firstname`, `name`, `lastname`, `phone`, `street`, `corpus`, `home`, `float`, `massage`)
                         VALUES('$name','$firstname','$lastname','$phone','$street','$corpus','$home','$float','$massage')");
if ($result = 'true'){
    echo '<script>location.replace("indexServer.php");</script>';
}

?>