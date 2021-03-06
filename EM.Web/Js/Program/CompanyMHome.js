
function PeiChart(ob, limits, ds, de) {
    var _this = this;
    _this.sm = {
        ds: ds,
        de: de,
    };
    _this.ob = ob
    _this.height = '50%';
    _this.GetNames = function (limits) {
        var names = new Array();
        for (var i = 0; i < limits.length; i++) {
            names.push(limits[i].CateName)
        }
        return names;
    }
    _this.GetSeries = function (limits) {
        var series = new Array();
        var color = Global.Utils.RandomColor();
        for (var i = 0; i < limits.length; i++) {
            var serie = {
                name: '产品开拓类',
                type: 'pie',
                center: ['10%', _this.height],
                radius: _this.radius,
                x: '0%', // for funnel
                data: [
                    { name: '剩余额度', y: 89654 },
                    { name: '产品开拓费', y: 231 },
                    { name: '预计使用额度', y: 89654 },
                ],
                size:100
            }
            var colorList = new Array();
            var colorSpan = 20;
            var rgb = color.replace("#", "");
            for (var j = 0; j < 3; j++) {
                var r = parseInt(rgb.substr(0, 2), 16) + j * colorSpan;
                var g = parseInt(rgb.substr(2, 2), 16) +j * colorSpan;
                var b = parseInt(rgb.substr(4, 2), 16) + j * colorSpan;
                var rs = r.toString(16).substr(0, 2);
                var gs = g.toString(16).substr(0, 2);
                var bs = b.toString(16).substr(0, 2);
                var colorTemp = "#" + rs + gs + bs;
                colorList.push(colorTemp);
            }
            console.log(colorList)
            var limit = limits[i];
            serie.name = limit.CateName;
            serie.center[0] = (12+ i * 18)+'%';
            serie.x = (i * 20)+'%';
            serie.data[0].y = limit.TotalRest
            serie.data[0].color = colorList[0];
            serie.data[1].name = limit.CateName;
            serie.data[1].color = colorList[1];
            serie.data[1].y = limit.TotalCost;
            serie.data[2].y = limit.ExpectTotalCost;
            serie.data[2].color = colorList[2];
            series.push(serie)
        }
        return series;
    }
    _this.PeiOption = {
        tooltip: {
            formatter: function () {
                if (this.key != "剩余额度")
                    var tag = "{key}已使用{y}元（{percent}）".format({ key: this.key, y: this.y, percent: this.percentage.toFixed(2) })
                else
                    var tag = "剩余{y}元（{percent}）".format({ key: this.key, y: this.y, percent: this.percentage.toFixed(2) })
                return tag;

            },
        },
        legend: {
            x: 'center',
            y: 'bottom',
            data: _this.GetNames(limits)
        },
        title: {
            text: '报销额度使用情况一览'
        },
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: null,
            plotShadow: false
        },
        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                dataLabels: {
                    style:{"color": "contrast", "fontSize": "6px", "fontWeight": "100", "textShadow": "0 0 6px contrast, 0 0 3px contrast" },
                    format: ' {point.name}: {point.percentage:.1f} %',
                    x: 10,
                    y: 0
                },
            },
            series: {
                cursor: 'pointer',
                events: {
                    click: function (e) {
                    }
                },
            }
        },
        series: _this.GetSeries(limits)
    }
    _this.Init = function () {
        var PeiChartOb = $(_this.ob).highcharts(_this.PeiOption);
        return PeiChartOb;
    }
}

function LineChart(ob,limit,ds,de)
{
    var _this = this;
    _this.sm = {
        ds: ds,
        de: de,
    };
    _this.ob = ob
    _this.GetCostSeries = function (limit) {
        var series = new Array();
        var ds = _this.sm.ds.split('/')
        var de = _this.sm.ds.split('/')
        var startDate= Date.UTC(ds[0], ds[1] - 1, ds[2]);
        var endDate = Date.UTC(de[0], de[1] - 1, de[2]);
        var serieCost = {
            type: 'area',
            name: '已确认报销单',
            pointInterval: 24 * 3600 * 1000,
            pointStart: startDate,
            pointEnd: endDate,
            data: []
        }
        serieCost.data = [];
        if (limit.DateDetails != undefined) {
            for (var j = 0; j < limit.DateDetails.length; j++) {
                var detail = limit.DateDetails[j]
                var detailDate = detail.OccurDateName.split("-")
                var detailTime = Date.UTC(detailDate[0], detailDate[1] - 1, detailDate[2]);
                serieCost.data.push([
                    detailTime,
                    detail.Money - 0,
                ])
            }
        }
        if (serieCost.data.length != 0)
            series.push(serieCost)


        var serieExpect = {
            type: 'area',
            name: '确认中报销单',
            pointInterval: 24 * 3600 * 1000,
            pointStart: startDate,
            pointEnd: endDate,
            data: []
        }
        if (limit.ExpectDateDetails != undefined) {
            for (var j = 0; j < limit.ExpectDateDetails.length; j++) {
                var detail = limit.ExpectDateDetails[j]
                var detailDate = detail.OccurDateName.split("-")
                var detailTime = Date.UTC(detailDate[0], detailDate[1] - 1, detailDate[2]);
                serieExpect.data.push([
                    detailTime,
                    detail.Money - 0,
                ])
            }
        }
        if (serieExpect.data.length != 0)
            series.push(serieExpect)
        return series
    },
    _this.LineOption = {
        chart: {
            type: 'column'
        },
        title: {
            text: '报销单明细一览表'
        },
        subtitle: {
            text: document.ontouchstart === undefined ?
                '鼠标拖动来查看时间' :
                '手指缩放来查看时间'
        },
        xAxis: {
            type: 'datetime',
            maxZoom: 14 * 24 * 3600000, // fourteen days
            title: {
                text: '费用发生日期'
            }
        },
        yAxis: {
            title: {
                text: '报销金额'
            }
        },
        legend: {
            enabled: true
        },
        plotOptions: {
            area: {
                fillColor: {
                    linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                    stops: [
                        [0, Highcharts.getOptions().colors[0]],
                        [1, Highcharts.Color(Highcharts.getOptions().colors[0]).setOpacity(0).get('rgba')]
                    ]
                },
                lineWidth: 1,
                marker: {
                    enabled: false
                },
                shadow: false,
                states: {
                    hover: {
                        lineWidth: 1
                    }
                },
                threshold: null
            }
        },
        series: _this.GetCostSeries(limit)
    }

    _this.Init = function () {
        $(_this.ob).highcharts(_this.LineOption);
    }
}


function BarLimitChart(ob, limits) {
    var _this = this;
    _this.ob = ob
    _this.GetNames = function (limits) {
        var names = new Array();
        for (var i = 0; i < limits.length; i++) {
            names.push(limits[i].CateName)
        }
        return names;
    }
    _this.GetSeries = function (limits) {
        var series = new Array();
        series.push({ name: "剩余额度", data: [], color: "#" + (238).toString(16) + (225).toString(16) + (160).toString(16) });
        series.push({ name: "预计使用", data: [], color: "#" +(246).toString(16) + (173).toString(16) + (60).toString(16) });
        series.push({ name: "已使用", data: [], color: "#" + (219).toString(16) + (79).toString(16) + (46).toString(16) });
        var color = Global.Utils.RandomColor();
        for (var i = 0; i < limits.length; i++) {
            var limit = limits[i]
            series[0].data.push(limit.TotalRest)
            series[1].data.push(limit.ExpectTotalCost)
            series[2].data.push(limit.TotalCost)
        }
        return series;
    }
    _this.BarOption = {
        chart: {
            type: 'bar'
        },
        title: {
            text: '报销额度使用情况一览'
        },
        yAxis: {
            min: 0,
            title: {
                text: null
            },
            gridLineDashStyle: 'longdash'
        },
        legend: {
            reversed: true
        },
        plotOptions: {
            series: {
                stacking: 'normal',
            }
        },
        xAxis: {
            categories: _this.GetNames(limits),
            lineWidth: 0,
            tickLength: 5,
            gridLineDashStyle: 'longdash'
        },
        series: _this.GetSeries(limits),
        credits: {
            enabled: false
        }
    }
    _this.Init = function () {
        var BarChartOb = $(_this.ob).highcharts(_this.BarOption);
        return BarChartOb;
    }
}


function BarPerformanceChart(ob, Performance) {
    var _this = this;
    _this.ob = ob
    _this.GetSeries = function (Performance) {
        var cololWaitFinishPerformance = '#fdd000'// '#f299a9'//Global.Utils.RandomColor()
        var cololFinishdPerformance = '#ff1301'//Global.Utils.RandomColor()
        var series = new Array();
        series.push({ name: "待完成业绩", data: [Performance.TotalPerformance - Performance.FinishPerformance], color: cololWaitFinishPerformance });
        series.push({ name: "已完成业绩", data: [Performance.FinishPerformance], color: cololFinishdPerformance });
        //$("#Color").html(cololWaitFinishPerformance + "," + cololFinishdPerformance);
        return series;
    }
    _this.BarOption = {
        chart: {
            type: 'bar'
        },
        title: {
            text: $("#companyName").val() + '业绩完成情况(万元)'
        },
        legend: {
            reversed: true
        },
        plotOptions: {
            series: {
                stacking: 'normal',
            }
        },
        subtitle: {
            text: "最新录入时间：" + Performance.EndDateName
        },
        yAxis: {
            max:Performance.TotalPerformance,
            min: 0,
            title: {
                text: null
            },
            gridLineDashStyle: 'longdash'
        },
        xAxis: {
            categories: ["业绩完成情况"],
            lineWidth: 0,
            tickLength: 5,
            gridLineDashStyle: 'longdash'
        },
        series: _this.GetSeries(Performance),
        credits: {
            enabled: false
        }
    }
    _this.Init = function () {
        var BarChartOb = $(_this.ob).highcharts(_this.BarOption);
        return BarChartOb;
    }
}


