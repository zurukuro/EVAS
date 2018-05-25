/* Funções abaixo captura dados do banco para realizar o analytics */
//-----------------------------------------------------------------//

/*A cada 1 segundo executa a Query de pegar a 
 * menor temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaMinima',
        data: '{}',
        success: function (response) {
            document.getElementById('tempMin').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //

/*A cada 1 segundo executa a Query de pegar o 
 * 1º Quartil de temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaQuartil1',
        data: '{}',
        success: function (response) {
            document.getElementById('tempQuartil1').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //


/*A cada 1 segundo executa a Query de pegar a 
 * Mediana (2ºQuartil) temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaMediana',
        data: '{}',
        success: function (response) {
            document.getElementById('tempMediana').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //


/*A cada 1 segundo executa a Query de pegar a 
 * média da temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaMedia',
        data: '{}',
        success: function (response) {
            document.getElementById('tempMedia').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //

/*A cada 1 segundo executa a Query de pegar a 
 * 3º Quartil de temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaQuartil3',
        data: '{}',
        success: function (response) {
            document.getElementById('tempQuartil3').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //

/*A cada 1 segundo executa a Query de pegar a 
 * Maior temperatura das ultimas 3 horas */
setInterval(function () {
    $.ajax({
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json',
        url: 'painel.aspx/TemperaturaMaxima',
        data: '{}',
        success: function (response) {
            document.getElementById('tempMax').innerHTML = (Math.round(response.d) + 'ºC');
        },
        error: function () {
        }
    });
}, 1000);
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - //

//-----------------------------------------------------------------//
/* Funções acima captura dados do banco para realizar o analytics */