<?php
	//������������� ������� � ���� ������:
		$host = 'localhost'; //��� �����, �� ��������� ���������� ��� localhost
		$user = 'root'; //��� ������������, �� ��������� ��� root
		$password = ''; //������, �� ��������� ������
		$db_name = 'database'; //��� ���� ������

	//����������� � ����� ������ ��������� ���� �������:
		$link = mysqli_connect($host, $user, $password, $db_name);
