$(function () {
    $(".btn-left").mouseover(function () {
        $(".drop-content-left").removeClass("d-none")
    })
    $(".drop-content-left").mouseleave(function () {
        $(".drop-content-left").addClass("d-none")
    })
    $(".btn-right").mouseover(function () {
        $(".drop-content-right").removeClass("d-none")
    })
    $(".drop-content-right").mouseleave(function () {
        $(".drop-content-right").addClass("d-none")
    })
    $("#home-btn").mouseover(function () {
        $(".home-nav").addClass("visible")

    })
    $(".home-nav").mouseleave(function () {
        $(".home-nav").removeClass("visible")
    })
    $("#shop-btn").mouseover(function () {
        $(".shop-nav").addClass("visible")

    })
    $(".shop-nav").mouseleave(function () {
        $(".shop-nav").removeClass("visible")
    })
    const nextIcon = '<i class="fas fa-arrow-right"></i>';
    const prevIcon = '<i class="fas fa-arrow-left"></i>';
    $('.advert-top').owlCarousel({
        
        animateOut: 'slideOutDown',
        animateIn: 'flipInX',
        items:1,
        margin:0,
        stagePadding:0,
        smartSpeed:450,
        animateIn:true,
        animateOut:true,
        navText:[prevIcon,nextIcon],
        loop:true,
         dots:false,
         nav:true
    });
    var clock = $('.clock').FlipClock({
        clockFace: 'DailyCounter',
        autoStart: false,
        callbacks: {
          stop: function() {
            $('.message').html('The clock has stopped!')
          }
        }
    });
    clock.setTime(220880);
    clock.setCountdown(true);
    clock.start();

    

    $(document).on("mouseover",".discount-card",function () {

        $(this).children().last().children().last().removeClass("display-none")
        $(this).css("height","360px")
        $(this).children().last().children().last().css({
            "margin-top":"10px",
            "transition":"all 0.2s"
        })
    })
    $(document).on("mouseleave",".discount-card",function () {
        $(this).children().last().children().last().addClass("display-none")
        $(this).css("height","348px")
        $(this).children().last().children().last().css({
            "margin-top":"0px",
            "transition":"all 0.2s"
        })

    })


    $(document).on("mouseover",".buy-now-card",function () {

        $(this).children().last().children().last().removeClass("display-none")
        $(this).css("height","450px")
        
        $(this).children().last().children().last().css({
            "margin-top":"10px",
            "transition":"all 0.2s"
        })
    })
    $(document).on("mouseleave",".buy-now-card",function () {
        $(this).children().last().children().last().addClass("display-none")
        $(this).css("height","400px")
        
        $(this).children().last().children().last().css({
            "margin-top":"0px",
            "transition":"all 0.2s"
        })

    })
    
    $('.owl-carousel').owlCarousel({
        loop:true,
        margin:10,
        nav:true,
        dots:false,
        
        
        smartSpeed: 1500,
        animateIn: 'linear',
        animateOut: 'linear',
        responsive:{
        
            0:{
                items:1
            },
            600:{
                items:3
            },
            1000:{
                items:5
            }
        }
    })

    $(document).on("click",".product-categories-plus",function () {
        $(this).parent().parent().children().last().toggleClass("d-none");
        $(this).toggleClass("fas fa-plus")
        $(this).toggleClass("fas fa-minus")
        if($(".product-categories-checkbox").css("height")>"255px"){
            $(".product-categories-checkbox").css("overflow-y","scroll")
        }
        else{
           
            $(".product-categories-checkbox").css("overflow-y","auto")
        }
    })

    

    var slider = document.getElementById("myRange");
    var output = document.getElementById("demo");
    output.innerHTML = slider.value;

    slider.oninput = function() {
    output.innerHTML = this.value;

    }

    $(document).on("click", "#add-to-cart",function () {
        $.ajax({
            type: "POST",
            url: baseUrl + "/cart" +"/index",
            data: "check",
            success: function (response) {
                alert(response)
            }
        });
    })



})
function openContent(evt, contentName) {
    var i, tabcontent, tablinks;
  
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
      tabcontent[i].style.display = "none";
    }
  
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
      tablinks[i].className = tablinks[i].className.replace(" active", "");
    }
  
    document.getElementById(contentName).style.display = "block";
    evt.currentTarget.className += " active";
  }