<div id="block-header">
    <div id="header-mid">    
        <img src="images/logok.png" OnClick="location.href='index.php'">
       <!-- <p>������-������</p>-->
    </div>
    
<!--SEEEEACH-->
<div class="d1">
  <form>
    <input id="text-search" type="text" placeholder="�����..."/>
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
				<input type="submit" value="���������">
			</form>
		</div>
    <script type="text/javascript">
		$(document).ready(function() { // ��� �������� ��������
        $(".block-content").click(function(){	// ������� ����� �� ����������� ���
		$(".popup").fadeOut(800);	// �������� ������� ����������� ����
	});

});

function showPopup() {
	$(".popup").fadeIn(800); // �������� ������� �����������
}
	</script>
	   </div>
</div>
