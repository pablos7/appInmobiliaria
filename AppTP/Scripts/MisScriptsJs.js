$(document).ready(function () {
    var altura = $('#main_menu').offset().top;

    $(window).on('scroll', function () {
        if ($(window).scrollTop() > altura) {
            $('#main_menu').addClass('navbar-fixed-top');
        } else {
            $('#main_menu').removeClass('navbar-fixed-top');
        }
    });

    $("a").click(function () {
        $('#login_form').modal("show");
    });
});