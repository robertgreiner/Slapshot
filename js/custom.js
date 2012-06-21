// JavaScript Document
Cufon.replace('h1,h2,h3,.tagline,a.various',{textShadow: '0px 1px 0px #ffffff'});    
Cufon.replace('.button_1 a, .button_2 a');  

$(document).ready(function(){
//Fancybox for image gallery
$("a.simple_image").fancybox({
		'opacity'		: true,
		'overlayShow'	       : true,
		'overlayColor': '#000000',
		'overlayOpacity'     : 0.9,
		'titleShow':true,
		'transitionIn'	: 'elastic',
		'transitionOut'	: 'elastic'
});

//fancybox for content to displayed on click
$(".various").fancybox({
			'hideOnOverlayClick': true, 
			'transitionIn'		:'elastic',
			'overlayShow'		:false,
			'speedIn'			:600,
			'titleShow':false,
			'overlayShow': true,
			'overlayOpacity': 0.8,
			'overlayColor': '#000000'
		});

//Gallery - On Hover Event 
	$('ul.gallery li a').mouseenter(function(e) {
            $(this).children('img').animate(300);
            $(this).children('span').fadeIn(400);
        }).mouseleave(function(e) {
            $(this).children('img').animate(300);
            $(this).children('span').fadeOut(400);
});

//On Hover Event for social 
	$('#footer li a img').hover(function(){
			$(this).animate({opacity: 0.6}, 300);
		}, function () {
			$(this).animate({opacity: 1}, 300);
		});

}); // close document.ready
