$(function() {

	var graficoExiste = false;
	var chart;

	if (document.getElementById("chart").length > 0) {
		graficoExiste = true;
	}


	$(window).on("scroll", function () {
		const about_size = $(".front-about").height() - $("#header").height();
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

	function initChart() {
		var context = document.getElementById("chart").getContext("2d");
		context.canvas.width = 900;
		context.canvas.height = 500;
		
		var configuration = {
			type: 'line',
			data: {
				datasets: [{
					label: "Temperatura por segundo",
					type: 'line',
				}]
			},
			options: {
				scales: {
					xAxes: [{
						//type: 'value',
						distribution: 'series',
						ticks: {
							beginAtZero:false
						}
					}],
					yAxes: [{
						scaleLabel: {
							display: true
							// labelString: 'Temperature'
						},
						ticks: {
							beginAtZero:false
						}
					}]
				},
				animation: {
					duration: 0
				}
			}
		};
		
		chart = new Chart(context, configuration);
		//Esse atributo dentro do contexto serve para saber qual foi o último índice processado, assim eliminado os outros elementos na
		//hora de montar/atualizar o gráfico
		this.lastIndexTemp = 0;
		this.time = 0;
	}

	$('#details').on('click',function(){
		$('#idhidden').toggleClass('hidden');

		if($('#idhidden').hasClass('hidden')){
			graficoExiste = false;
		} else {
			graficoExiste = true;
			initChart();
		}
	});

	if(graficoExiste) {
		initChart();
	}
			
	//Função para obter os dados de temperatura do server
	//Seria mais interessante fazer isso com WebSocket, porém para fins academicos, os dados serão atualizados via HTTP

	function get_data(){

		var http = new XMLHttpRequest();
		http.open('GET', 'http://localhost:3000/api', false);
		http.send(null);        
		
		var obj = JSON.parse(http.responseText);

		if (obj.data.length == 0){
			return;
		}

		var _lastIndexTemp = this.lastIndexTemp;
		this.lastIndexTemp = obj.data.length;

		document.getElementById('temp').innerHTML = Math.round(obj.data[obj.data.length - 1]);
		// document.getElementById('temp_1quartil').innerHTML = Math.round(obj.data[obj.data.length - 1]);
		// document.getElementById('temp_3quartil').innerHTML = Math.round(obj.data[obj.data.length * (100) / (100)]);
		// document.getElementById('temp_media').innerHTML = Math.round(obj.data[obj.data.length - 1]);
		document.getElementById('temp-stroke').setAttribute('stroke-dasharray', Math.round(obj.data[obj.data.length - 1])  * 2 + ', 100');
		
		if(graficoExiste) {
			listTemp = obj.data.slice(_lastIndexTemp);
			listTemp.forEach(data => {
				//Máximo de 60 itens exibidos no gráfico
				if (chart.data.labels.length == 10 && chart.data.datasets[0].data.length == 10){
					chart.data.labels.shift();
					chart.data.datasets[0].data.shift();
				}

				chart.data.labels.push(this.time++);
				chart.data.datasets[0].data.push(parseFloat(data));
				chart.update();
			});
		}
		//document.getElementById('average').textContent = obj.average
	} 
	
	get_data();

	setInterval(() => {
		get_data();
	}, 1000);

	$('#arduino_details').on('click',function(){
		$('#arduino_stats').addClass('show');
		console.log("oi");

		if($('#arduino_stats').hasClass('show')){
			$('#arduino_details').addClass('hidden')
		}
	});

	$('#details').on('click',function(){
		$('#media_stats').toggleClass('hidden');

		if($('#media_details').hasClass('hidden')){
			$('#media_details').addClass('hidden')
		} else {
			$('#media_details').removeClass('hidden')
		}
	});
	graficoExiste = true;
	initChart();
});