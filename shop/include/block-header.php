<div id="block-header">
    <div id="header-mid">    
        <img src="images/logok.png" OnClick="location.href='index.php'">
       <!-- <p>КОРОНА-МАРКЕТ</p>-->
    </div>
    
<!--SEEEEACH-->
<div class="d1">
  <form>
    <input id="text-search" type="text" placeholder="Поиск..."/>
    <input id="button-search" type="submit" value=".">
  </form>
</div>
<!-----------search----------->
<div id="icons-header">
    <div id="social">
        <div id="vk" onclick="window.open('https://vk.com/liferest')"></div>
        <div id="fb" onclick="window.open('https://www.facebook.com/liferestinsta/')"></div>
        <div id="inst" onclick="window.open('https://www.instagram.com/liferest_insta/')"></div>
        
    </div>
</div><br />

    <a id="trash" href="korzina.php"></a>
    <button id="feedback" onclick="showPopup();"></button>
    <div id="profile-block">
    <div id="profile" OnClick="location.href='check.php'">

    </div>
        <p id="profile-name"><?php echo $_SESSION['logged_user']->login; ?> </p>
    </div>
    
    <div class="popup">
		<div class="form">
			<form>
				<input type="text" value="<?php echo $_SESSION['logged_user']->login; ?>" >
				<input type="text" value="<?php echo $_SESSION['logged_user']->email; ?>" >
				<textarea></textarea>
				<input type="submit" value="Отправить">
			</form>
		</div>
    <script type="text/javascript">
		$(document).ready(function() { // Ждём загрузки страницы
        $(".block-content").click(function(){	// Событие клика на затемненный фон
		$(".popup").fadeOut(800);	// Медленно убираем всплывающее окно
	});

});

function showPopup() {
	$(".popup").fadeIn(800); // Медленно выводим изображение
}
	</script>
	   </div>
</div>
