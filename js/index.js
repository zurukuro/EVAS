$(function() {
	$(window).on("scroll", function () {
		const about_size = $(".front-about,.frutech").height() - $("#header").height();
		if ($(this).scrollTop() > about_size) {
			$("#header").addClass("not-transparent");
		}
		else {
			$("#header").removeClass("not-transparent");
		}
	});

	// var typed = new Typed('.front-about__title', {
	//     strings: ["First sentence.", "Second sentence."],
	//     typeSpeed: 30
	// });

	// var i = 0;

	// while(i <= 31) {
	// 	window.setInterval(function(){
	// 		console.log(i);
	// 		$("#counter_1").innerHTML = i;
	// 		i++;
	// 	}, 50);
	// }	
});