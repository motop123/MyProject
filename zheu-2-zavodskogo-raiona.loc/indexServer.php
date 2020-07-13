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
		</div>
		<!--////////////////////////////////////Container-->
		<section id="container">
			<div class="wrap-container">
				<!-----------------content-box-1-------------------->
				<section class="content-box boxstyle-1 box-1">
					<div class="zerogrid">
						<div class="row wrap-box">
							<!--Start Box-->
							<div class="col-1-3">
								<div class="wrap-col">
									<div class="row" >
											<p class="widget-title" style="color: white;font-size: 20px">ОСНОВНЫЕ ЗАДАЧИ ОРГАНИЗАЦИИ:</p>
									*  обеспечение содержания и сохранности жилищного фонда, надлежащего его использования, контроль соблюдения жильцами правил содержания и использования жилыми и нежилыми помещениями, придомовой территории в соответствии с требованиями Жилищного кодекса Республики Беларусь; 
									<br>* организация эксплуатации, технического обслуживания жилищного фонда;<br>
								* cвоевременное принятие мер по предотвращению неисправностей и устранению аварий в работе инженерного оборудования и элементов жилых домов.
									</div>
									<br>
								</div>
							</div>
							<div class="col-1-3">
								<div class="wrap-col">
									<div class="row">
										<p class="widget-title" style="color: white;font-size: 20px">Где нас найти:</p>
											<strong>Город Минск</strong>
											<br>
											ул. Варвашени 6/4, Минск	
											<p>
											<p class="widget-title" style="color: white;font-size: 20px">Мы работаем:</p>
											<strong> Прием граждан и юридических лиц:</strong><br> ср 14.00-20.00 
											<br>1-я суббота месяца 9.00-12.00
											<br>
										</p>
									</div>
								</div>
							</div>
							<div class="col-1-3">
								<div class="wrap-col">
									<div class='viewport'>
    <ul class='slidewrapper' data-current=0>
        <li class='slide'>
           <img src="images\zavod1.jpg">
        </li>
        <li class='slide second'>
           <img src="images\zavod2.jpg">
        </li>
        <li class='slide third'>
           <img src="images\zavod3.jpg">
        </li>
    </ul>
</div>
								</div>
							</div>
						</div>
					</div>
				</section>	
	</div>
	<br>
	<div style="font-size: 21px;text-align: center ">НОВОСТИ <br></div><br>
	<div class="all">
		<input checked type="radio" name="respond" id="desktop">
			<article id="slider">
					<input type="radio" name="slider" id="switch1">
					<input type="radio" name="slider" id="switch2">
					<input type="radio" name="slider" id="switch3">
					<input type="radio" name="slider" id="switch4">
					<input type="radio" name="slider" id="switch5">
					<input type="radio" name="slider" id="switch6">
				<div id="slides">
					<div id="overflow">
						<div class="image">
							<article style="margin-left: 40px"><img src="images\2.png"><p style="font-size: 25px; margin-top: 20px" >IFC выделит Беларуси на расвитие частного сектора $100-120 млн.</p><p style="color: grey">Международная финансовая...<a style="margin-left: 10px" href="http://www.belta.by/economics/view/ifc-vydelit-belarusi-do-2022-goda-na-razvitie-chastnogo-sektora-100-120-mln-303906-2018/" target="_blank" class="link">Читать</a></p></article>
							<article style="margin-left: 20px"><img src="images\1.png"><p style="font-size: 25px; margin-top: 20px">Всемирный банк поддержит модернизацию высшего образованич в Беларуси</p><p style="color: grey">Всемирный банк поддержит...<a style="margin-left: 10px" href="http://www.belta.by/economics/view/vsemirnyj-bank-podderzhit-modernizatsiju-vysshego-obrazovanija-v-belarusi-303907-2018/" target="_blank" class="link">Читать</a></p></article>
							<article style="margin-left: 20px"><img src="images\3.png"><p style="font-size: 25px; margin-top: 20px">Летом данные о качестве воды в пляжных зонах будут публиковать еженедельно</p><p style="color: grey">Свежие данные о качестве воды...<a style="margin-left: 10px" href="https://minsk.gov.by/ru/news/new/2018/05/23/1181/" target="_blank" class="link">Читать</a></p></article>
							<article style="margin-left: 20px"><img src="images\4.png"><p style="font-size: 25px; margin-top: 20px">Служба занятости комплектует новые группы для обучения востребованным профессиям</p><p style="color: grey">Городская служба занятости...<a style="margin-left: 10px" href="https://minsk.gov.by/ru/news/new/2018/05/23/1180/" target="_blank" class="link">Читать</a></p></article>
                            
						</div>
					</div>
				</div>
				<div id="controls">
					<label for="switch1"></label>
					<label for="switch2"></label>
					<label for="switch3"></label>
					<label for="switch4"></label>
   
				</div>
				<div id="active">
					<label for="switch1"></label>
					<label for="switch2"></label>
                    
				</div>
			</article>
	</div>
	<div class="content-box boxstyle-1 box-1" style="font-size: 17px">
		<div>
			<p style="font-size: 21px;text-align: center;"><br>ПОЛЕЗНО ЗНАТЬ</p>
		</div>
		<section id="container">
			<div class="wrap-container">
				<!-----------------content-box-1-------------------->
				<section class="content-box boxstyle-1 box-1">
					<div class="zerogrid">
						<div class="row wrap-box">
							<!--Start Box-->
							<div class="col-1-3">
								<div class="wrap-col">
									<p style="text-align: justify;text-indent: 25px;color: white;font-size: 20px; font-weight: bold;">О безопасности лично каждому горожанину Минска!</p><p style="text-align: justify;text-indent: 25px">Работники Заводского РОЧС продолжают проводить пожарно-профилактические мероприятия в жилом фонде.

<br>Актуальность проведения различного рода пожарно-профилактических мероприятий обусловлена напряженной обстановкой с пожарами. По информации о чрезвычайных ситуациях с начала 2018 года в Республике Беларусь произошло 2229 пожаров, на пожаре погибли 244 человека, в том числе 1 ребенок.

<br>В ходе обследований домовладений особое внимание обращалось на электрооборудование, наличие автономных пожарных извещателей. Также был произведен инструктаж граждан о необходимости соблюдения правил пожарной безопасности, оставлении детей без присмотра, разъяснены действия в случае возникновения чрезвычайной ситуации и вручены памятки по основам безопасности жизнедеятельности.</p>
								</div>
							</div>
							<div class="col-1-3">
								<div class="wrap-col">
									<p style="text-align: justify;text-indent: 25px;color: white;font-size: 20px; font-weight: bold;">Двухколесный друг: как сделать поездку безопасной?</p><p style="text-align: justify;text-indent: 25px">Для того, чтобы управлять велосипедом, не нужно сдавать экзамены на знание Правил дорожного движения и по навыкам вождения. Однако, для участников дорожного движения на двухколесных «машинах» существуют обязательные правила поведения на дороге. Зная и соблюдая их, можно сделать свою поездку безопасной. Эти правила просты.

<br>1. Велосипедисты должны держаться как можно ближе к краю проезжей части и ни в коем случае не отдаляться от него больше, чем на метр.
<br>2. По пешеходному переходу велосипед необходимо переводить в руках, а не ехать на нем.
<br>3. Запрещается управлять велосипедом, не держась за руль.
<br>4. В темное время суток необходимо обозначать велосипед спереди фонарем, который излучает белый, а сзади – красный свет.</p>
								</div>
							</div>
							<div class="col-1-3">
								<div class="wrap-col">
									<p style="text-align: justify;text-indent: 25px;color: white;font-size: 20px; font-weight: bold;">«Выжигание травы – преступление против природы»</p><p style="text-align: justify;text-indent: 25px">В последние годы весенние палы сухой растительности приобрели характер общенационального бедствия!

<br>Выжигание травы – преступление против природы, в результате которого:

<br>1. обедняется почва;
<br>2. огонь сжигает насекомых, мелких животных, гнезда птиц;
<br>3. сгорают не только сорняки, но и полезные растения;
<br>4. может загореться лес или постройки.
<br> Минский городской комитет природных ресурсов и охраны окружающей среды предупреждает:

<br><span style="font-weight: bold;">Согласно статье 15.57. Кодекса Республики Беларусь Об административных правонарушениях «За незаконное выжигание растительности, трав на корню – влекут наложение штрафа в размере от 10 до 40 базовых величин».</span></p>
								</div>
							</div>
						</div>
					</div>
				</section>	
	</div>
	<br>
	</div> 
	<br>
	<div style="font-size: 21px;text-align: center;">КАК НАС НАЙТИ</div><br>
	<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2352.729457977684!2d27.67369421591281!3d53.865458580091136!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46dbcdf1fd9c63e7%3A0xb41cde64b05765bb!2z0YPQuy4g0JLQsNGA0LLQsNGI0LXQvdC4IDYvNCwg0JzQuNC90YHQug!5e0!3m2!1sru!2sby!4v1522150484006" width="100%" height="450" frameborder="0" style="border:0;margin-bottom: 25px" allowfullscreen></iframe>
	<footer style="text-align:center;">
	<p style="color: white">ЧУО "Колледж бизнеса и Права" Жданович Юлия 2018</p><br>
	</footer>
</body>
</html>