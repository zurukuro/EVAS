$(window).on("scroll", function () {
    const about_size = $(".front-about").height() - $("#header").height();
    if ($(this).scrollTop() > about_size) {
        $("#header").addClass("not-transparent");
    }
    else {
        $("#header").removeClass("not-transparent");
    }
});