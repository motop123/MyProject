$(window).ready(function(){


	$(window).on('load', function () {
    $preloader = $('.preloader'),
      $loader = $preloader.find('.loader');
    $loader.fadeOut();
    $preloader.delay(350).fadeOut('slow');
 	});

//////////////////////////////////////////////////////////////////////////// 

	$('.header-menu-btn').on('click',function(e){
  		e.preventDefault;
  		$(this).toggleClass('header-menu-btn_active');
  	});

//////////////////////////////////////////////////////////////////////////// 
	 
	 var menu2 = $('.m-menu2');
	 var menu3 = $('.m-menu3');
	 var menu = $('.m-menu');
	 var link3 = $('.m-about');
	 var link2 = $('.m-services');
	 var link = $('.header-menu-btn');
	 var close3 = $('.close-menu3');
	 var close2 = $('.close-menu2');
	 var close = $('.close-menu');
	
	 link3.on('click', function(event){ 
	 	menu3.toggleClass('m-menu3__active');
	 });
	 link2.on('click', function(event){ 
	 	menu2.toggleClass('m-menu2__active');
	 });
	 link.on('click', function(event){
		 event.preventDefault();
		 menu.toggleClass('m-menu__active');
	 });

	 close.on('click', function(event){
		 event.preventDefault();
		 menu.toggleClass('m-menu__active');
	 });
	 close2.on('click', function(event){
		 event.preventDefault();
		 menu2.toggleClass('m-menu2__active');
	 });
	 close3.on('click', function(event){
		 event.preventDefault();
		 menu3.toggleClass('m-menu3__active');
	 });


	
	 $(document).ready(function(){
	    $(".btn-menuuus").on("click","a", function (event) {
	        event.preventDefault();
	        var id  = $(this).attr('href'),
	            top = $(id).offset().top;
	        $('body,html').animate({scrollTop: top}, 1500);
	    });
	});






});
