<!DOCTYPE html>
<head>
    <!-- Basic Page Needs
  ================================================== -->
	<meta charset="utf-8"> 
	<meta name="viewport" content="width=device-width, initial-scale=1">   
    <!-- CSS
	================================================== -->
  	<link rel="stylesheet" href="css/zerogrid.css">
	<link rel="stylesheet" href="css/style.css">
	<script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
<script src="css/slaider.js"></script>
	<!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link rel="stylesheet" href="css/menu.css">	
	<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
<script>
	/*Всплывашка для Обратной связи*/
/*открываю попап*/
$(document).ready(function() { 
	$('a#start').click( function(event){ 
		event.preventDefault(); 
		$('#overlay').fadeIn(250, 
		 	function(){
				$('#popUp') 
					.css('display', 'block') 
					.animate({opacity: 1, top: '55%'}, 490); 
		});
	});
/*по нажатию на крестик закрываю окно*/
	$('#close, #overlay').click( function(){ 
		$('#popUp')
			.animate({opacity: 0, top: '35%'}, 490, 
				function(){ 
					$(this).css('display', 'none'); 
					$('#overlay').fadeOut(220); 
				}
			);
	});
});
</script>

<script>
	/*Всплывашка для Обратной связи*/
/*открываю попап*/
$(document).ready(function() { 
	$('a#start1').click( function(event){ 
		event.preventDefault(); 
		$('#overlay').fadeIn(250, 
		 	function(){
				$('#popUp1') 
					.css('display', 'block') 
					.animate({opacity: 1, top: '55%'}, 490); 
		});
	});
/*по нажатию на крестик закрываю окно*/
	$('#close1, #overlay').click( function(){ 
		$('#popUp1')
			.animate({opacity: 0, top: '35%'}, 490, 
				function(){ 
					$(this).css('display', 'none'); 
					$('#overlay').fadeOut(220); 
				}
			);
	});
});
</script>
</head>
<body class="home-page">
	<div class="wrap-body" >
		<div class="header">
			<div id='cssmenu'>
				<ul class="menu" style="margin-left: 7%">
				   <li class=''><a href='indexServer.php'><span>ГЛАВНАЯ</span></a>
				   <li class=''><a href='indexPredUslug.php'><span>ПРЕДОСТАВЛЯЕМЫЕ УСЛУГИ</span></a>
				   <li class='has-sub'><a href=''><span>УЧАСТКИ ЖЭС</span></a><ul>
						 
							   <li><a href='index56.html'><span>ЖЭС № 56</span></a></li>
							   <li class='last'><a href='index87.html'><span>ЖЭС № 87</span></a></li>
							   <li><a href='index93.html'><span>ЖЭС № 93</span></a></li>
							</ul>
						 <li class=''><a href='indexGraph.php'><span>ГРАФИК УБОРКИ</span></a>
						 <li class=''><a href='#' id="start1"><span>ЗАДАТЬ ВОПРОС</span></a>					
						 </li>
						 <li class="active"><a href="" id="start"><span >Обратная связь</span></a></li>
                          <li class=''><a href='AuthForm.php'><span> <img src="images/profile.png" style="width: 12px;"> </span></span></a>
					  </ul></li>
                      
			</div>
				<div>
					<img src="images/shapka1.jpg">
				</div>
                <!-- PopUp ОбратнаяСвязь-->
		<div id="popUp" > 
      		<span id="close">X</span> 		
      		<form id="contact" action="InsertDataBase.php" method="post" name="contact">
            <fieldset>
            <legend style="color: white;">Здравствуйте, оставьте заявку</legend>
            <input required="" maxlength="10" id="name" class="txt" name="firstname" type="name" placeholder="Ваша Фамилия" />
            <input required="" maxlength="10" id="name" class="txt" name="name" type="name" placeholder="Ваше Имя" />            
            <input required="" maxlength="10" id="name" class="txt" name="lastname" type="name" placeholder="Ваше Отчество" />
            <input required="" maxlength="13" id="phone" class="txt" name="phone" type="phone" placeholder="Ваш мобильный телефон" /> 
            <input required="" maxlength="20" id="home" class="txt" name="street" type="text" placeholder="Ваша улица" />
            <input required="" maxlength="2" id="home" class="txt" name="corpus" type="text" placeholder="Ваш корпус" />
            <input required="" maxlength="5" id="home" class="txt" name="home" type="text" placeholder="Ваш дом" />
            <input required="" maxlength="5" id="home" class="txt" name="float" type="text" placeholder="Ваша квартира" />
            <textarea required="" maxlength="50" id="msg" class="txtarea"  name="massage" placeholder="Ваше сообщение:"></textarea>
            <input id="send" type="submit" value="Отправить">
            </fieldset>
            </form> 
	</div>
	<!--PupUp Задать вопрос-->
	<div id="popUp1">
      		<span id="close1">X</span> 		
      		<form id="contact" action="mail.php" method="post" name="contact">
            <fieldset>
            <legend style="color: white;">Возник вопрос? Задавайте</legend>
            <input id="name" class="txt" name="email" type="email" placeholder="Ваш email" />
            <textarea id="msg" class="txtarea"  name="msg" placeholder="Ваш вопрос:"></textarea>
            <input  id="send" type="submit" value="Отправить">
            </fieldset>
            </form> 
	</div>
<div id="overlay"></div>
		<!--////////////////////////////////////Container-->
        <form>
        <p style="text-align: center;font-size: 21px;background-color: #1A1C1E;color: white;">СПИСОК ЗАЯВОК</p>
			<table border='1' width='1000'>
<tbody>
<tr>
<td style="font-weight: bold;">№</td>
<td style="font-weight: bold;">Услуга</td>
<td style="font-weight: bold;">Цена будних дней в руб.</td>
<td style="font-weight: bold;">Цена выходных дней в руб.</td>
</tr>


<?php

// ваш адрес где находится, хостится ваша база данных

$sdd_db_host='localhost';

// Имя базы данных с которой вы хотите работать, так как их может быть множество

$sdd_db_name='DataBase';

// логин доступ к базе данных

$sdd_db_user='root';

// пароль доступа к базе данных

$sdd_db_pass='';



@mysql_connect($sdd_db_host,$sdd_db_user,$sdd_db_pass);

@mysql_select_db($sdd_db_name);

$result=mysql_query('SELECT * FROM `preduslug`');

while ($row=mysql_fetch_array($result))

{ // выводим данные

echo "<tr>\n\t<td>".$row["id"]."</td>"."\n\t"."<td>"."".$row["usluga"]."</td>"."\n\t"."<td>"."".$row["budnie"]."</td>"."\n\t"."<td>"."".$row["vihodnie"]."</td>"."</tr>";

}

mysql_close();

?>

</tbody>
</table><br />
		</form>
		<br>
	</div>
	<footer style="text-align:center;">
	<p style="color: white">ЧУО "Колледж бизнеса и Права" Жданович Юлия 2018</p><br>
	</footer>
</body>
</html>