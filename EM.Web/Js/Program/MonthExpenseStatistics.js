
function ColumnChart(ob, model) {
    var _this = this;
    _this.ob = ob
    _this.GetSeries = function (model) {
        var series = new Array();
        for (var key in model.List)    
        {
            var data = [];
            for (var i = 0; i < model.List[key].length; i++) {
                data.push(model.List[key][i].SumMoney)
            }
            series.push({
                name: key,
                data: data,
            })
        }
        return series;
    }
    _this.ColumnOption ={
        chart: {
            type: 'column'
        },
        title: {
            text: model.title
        },
        subtitle: {
            text: model.subtitle
        },
        xAxis: {
            categories: model.NameList,
        },
        yAxis: {
            min: 0,
            title: {
                text: '费用 (元)'
            }
        },
        tooltip: {
            headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
            pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
                '<td style="padding:0"><b>{point.y:.1f} 元</b></td></tr>',
            footerFormat: '</table>',
            shared: false,
            useHTML: true
        },
        plotOptions: {
            column: {
                pointPadding: 0.2,
                borderWidth: 0
            }
        },
        series: _this.GetSeries(model)

        }
    _this.Init = function () {
        var ColumnChartOb = $(_this.ob).highcharts(_this.ColumnOption);
        return ColumnChartOb;
    }
}


