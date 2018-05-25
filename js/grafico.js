google.charts.load('current', { packages: ['corechart', 'line'] });
google.charts.setOnLoadCallback(desenharGrafico);

var total = 0, grafico = null, data = null;

function desenharGrafico() {
    if (data == null) {
        data = new google.visualization.DataTable();
        data.addColumn('number', 'Tempo');
        data.addColumn('number', 'Temperatura ºC');

        grafico = new google.visualization.LineChart(document.getElementById('chartdiv'));
    }
    var options = {
        title: 'Temperaturas em Tempo Real (Ultimos 10 Segundos)',
        curveType: 'function',
        legend: { position: 'bottom' }
    };

    grafico.draw(data, options);

    setTimeout(function () {
        $.ajax({
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json',
            url: 'painel.aspx/TemperaturaAtual',
            data: '{}',
            success: function (response) {
                if(data.getNumberOfRows() > 10)
                {
                    data.removeRow(0);
                }
                data.addRow([total, response.d]);
                total++;
                $('#temp').text(Math.round(response.d) + 'ºC');
                document.getElementById('temp-stroke').setAttribute('stroke-dasharray', Math.round(response.d) * 2 + ', 100');
                desenharGrafico();
            },
            error: function () {
            }
        });
    }, 1000);
}