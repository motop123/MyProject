<?php
	//”станавливаем доступы к базе данных:
		$host = 'localhost'; //им€ хоста, на локальном компьютере это localhost
		$user = 'root'; //им€ пользовател€, по умолчанию это root
		$password = ''; //пароль, по умолчанию пустой
		$db_name = 'database'; //им€ базы данных

	//—оедин€емс€ с базой данных использу€ наши доступы:
		$link = mysqli_connect($host, $user, $password, $db_name);
