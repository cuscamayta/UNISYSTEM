$(document).ready(function(){
$('.nav-mobile-ul').mobileMenu({
	defaultText: 'Navigation',
	className: 'select-menu',
	subMenuDash: '&ndash;'
});

});




$(document).ready(function(){
			$('.toggle-menu').each(function(){
				$(this).find('.togglebox').hide();
			});
 
			$('.toggle-menu h3').click(function(){
				var el = $(this), parent = el.closest('.toggle-menu');
				if( el.hasClass('active') )
			{
				parent.find('.togglebox').slideToggle();
				el.removeClass('active');
			}
			else
			{
				parent.find('.togglebox').slideToggle();
				el.addClass('active');
			}
			return false;
			});
});


		jQuery(document).ready(function($) {
			$('.toggle-menu1').each(function(){
				$(this).find('.togglebox1').show();
			});
			$('.toggle-menu1 h3').click(function(){
				var el = $(this), parent = el.closest('.toggle-menu1');
				if( el.hasClass('active') )
				{
					parent.find('.togglebox1').slideToggle();
					el.removeClass('active');
				}
				else
				{
					parent.find('.togglebox1').slideToggle();
					el.addClass('active');
				}
				return false;
			});
		});



$(document).ready(function(){
			$('.toggle-menu2').each(function(){
				$(this).find('.togglebox2').hide();
			});
 
			$('.toggle-menu2 h3').click(function(){
				var el = $(this), parent = el.closest('.toggle-menu2');
				if( el.hasClass('active') )
			{
				parent.find('.togglebox2').slideToggle();
				el.removeClass('active');
			}
			else
			{
				parent.find('.togglebox2').slideToggle();
				el.addClass('active');
			}
			return false;
			});
});



$(document).ready(function(){
			$('.toggle-menu3').each(function(){
				$(this).find('.togglebox3').hide();
			});
 
			$('.toggle-menu3 h3').click(function(){
				var el = $(this), parent = el.closest('.toggle-menu3');
				if( el.hasClass('active') )
			{
				parent.find('.togglebox3').slideToggle();
				el.removeClass('active');
			}
			else
			{
				parent.find('.togglebox3').slideToggle();
				el.addClass('active');
			}
			return false;
			});
});



jQuery(document).ready(function($) {
  "use strict";

// slider
$("#sliderRange")
.slider({
    range: true,
    min: 0,
    max: 500,
    step: 1,
    values: [0, 394],
    slide: function(event, ui) {
        var price1 = ui.values[0];
        var price2 = ui.values[1];
        $("#price1")
        .val("\u20ac" + price1);
        $("#price2")
        .val("\u20ac" + price2);
    }
});
$('#price1')
.bind('keyup', function() {
    var from = $(this)
    .val();
    var to = $('#price2')
    .val();
    $('#sliderRange')
    .slider('option', 'values', [from, to]);
});
$('#price2')
.bind('keyup', function() {
    var from = $('#price1')
    .val();
    var to = $(this)
    .val();
    $('#sliderRange')
    .slider('option', 'values', [from, to]);
});

});



jQuery(document).ready(function($) {

$(".p2").on('click', function() {
   $(".p2-img").show(500);
   $(".p1-img").hide(500);
   $(".p3-img").hide(500);
   $(".p4-img").hide(500);
});

$(".p1").on('click', function() {
   $(".p1-img").show(500);
   $(".p2-img").hide(500);
   $(".p3-img").hide(500);
   $(".p4-img").hide(500);
});

$(".p3").on('click', function() {
   $(".p3-img").show(500);
   $(".p1-img").hide(500);
   $(".p2-img").hide(500);
   $(".p4-img").hide(500);
});

$(".p4").on('click', function() {
   $(".p4-img").show(500);
   $(".p1-img").hide(500);
   $(".p2-img").hide(500);
   $(".p3-img").hide(500);
});


});



    $(document).ready(function() {
      $("#hshop-slider").owlCarousel({

      navigation : true,
      slideSpeed : 300,
      pagination : false,
      singleItem : false

      // "singleItem:true" is a shortcut for:
      // items : 4, 
      // itemsDesktop : 4,
      // itemsDesktopSmall : 4,
      // itemsTablet: 4,
      // itemsMobile : 4

      });
    });


    $(document).ready(function() {
      $("#blogpost-slider").owlCarousel({

      navigation : false,
      slideSpeed : 300,
      pagination : true,
      singleItem : true

      // "singleItem:true" is a shortcut for:
      // items : 1, 
      // itemsDesktop : false,
      // itemsDesktopSmall : false,
      // itemsTablet: false,
      // itemsMobile : false

      });
    });


    $(document).ready(function() {
      $("#owl-homeslider").owlCarousel({
	autoplay : true,
      navigation : false,
      slideSpeed : 300,
      pagination : true,
      singleItem : true

      // "singleItem:true" is a shortcut for:
      // items : 1, 
      // itemsDesktop : false,
      // itemsDesktopSmall : false,
      // itemsTablet: false,
      // itemsMobile : false

      });
    });


    $(window).load(function(){
      $('#quote-slider').flexslider({
        animation: "slide",
        controlNav: "thumbnails",
        start: function(slider){
          $('body').removeClass('loading');
        }
      });
    });

    $(document).ready(function() {
      $("#sermons-slider").owlCarousel({

      navigation : true,
      slideSpeed : 300,
      pagination : false,
      singleItem : true

      // "singleItem:true" is a shortcut for:
      // items : 1, 
      // itemsDesktop : false,
      // itemsDesktopSmall : false,
      // itemsTablet: false,
      // itemsMobile : false

      });
    });








$(window).load(function() {
  $('#donation-slider').flexslider({
    animation: "slide",
	directionnav: "true"
  });
});


$(window).load(function(){
	var $container = $('#folio');
	$container.isotope({
		itemSelector : '.folio-item'
	});
	var $optionSets = $('#portfolio .folio-filter'),
		$optionLinks = $optionSets.find('a');
	$optionLinks.click(function(){
		var $this = $(this);
		// don't proceed if already selected
		if ( $this.hasClass('selected') ) {
			return false;
		}
		var $optionSet = $this.parents('.folio-filter');
		$optionSet.find('.selected').removeClass('selected');
		$this.addClass('selected');
	// make option object dynamically, i.e. { filter: '.my-filter-class' }
	var options = {},
		key = $optionSet.attr('data-option-key'),
		value = $this.attr('data-option-value');
		
	// parse 'false' as false boolean
	value = value === 'false' ? false : value;
	options[ key ] = value;
		if ( key === 'layoutMode' && typeof changeLayoutMode === 'function' ) {
		changeLayoutMode( $this, options );
	} else {
		// otherwise, apply new options
		$container.isotope( options );
	}    
	return false;
	});

});



jQuery(document).ready(function($) {
  "use strict";
	$('.stats-wrap').appear(function() {
	$('#lines').animateNumber({ number: 9431 }, 1000 );
	$('#lines1').animateNumber({ number: 347 }, 1000 );
	$('#lines2').animateNumber({ number: 21 }, 1000 );
	$('#lines3').animateNumber({ number: 1094 }, 1000 );
	},{accX: 0, accY: -50});
});


    
$('.shop-accordion').accordion();


	function LoadGmaps() {
		var myLatlng = new google.maps.LatLng(40.7143528,-74.0059731);
		var myOptions = {
			zoom: 16,
			center: myLatlng,
			disableDefaultUI: true,
			panControl: true,
			zoomControl: true,
			zoomControlOptions: {
				style: google.maps.ZoomControlStyle.DEFAULT
			},

			mapTypeControl: true,
			mapTypeControlOptions: {
				style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR
			},
			streetViewControl: true,
			mapTypeId: google.maps.MapTypeId.ROADMAP
			}
		var map = new google.maps.Map(document.getElementById("MyGmaps"), myOptions);
		var marker = new google.maps.Marker({
			position: myLatlng,
			map: map,
			title:"newyork"
		});
	}


//==================== Parallax ========================//
jQuery(document).ready(function($) {
	$.stellar({
		horizontalScrolling: false,
		verticalOffset: 40
	});
});

