<?php 
require 'libs/rb.php';
R::setup( 'mysql:host=127.0.0.1;dbname=database','root', '' );

if ( !R::testconnection() )
{
		exit ('��� ���������� � ����� ������');
}

session_start();