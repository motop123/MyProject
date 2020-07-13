<?php
$hostname_connect = "localhost";
$database_connect = "DataBase";
$username_connect = "root";
$password_connect = "";


$connect = mysql_pconnect($hostname_connect,$username_connect,$password_connect) or trigger_error(mysql_error(),E_USER_ERROR);
mysql_select_db($database_connect);
//Вывод данных в кодировке
@mysql_query("set character_set_client='utf8'");
@mysql_query("set character_set_result='utf8'");
@mysql_query("set character_set_connection='utf8'");