

// load compare blocks
$(function ()
{
    



});












// for highcharts
/*
$(function () {

    var seriesData = [];
    var seriesLabels = [];
    var series = [];
    for (var p in graphData)
    {
        //seriesLabels.push(p);
        //seriesData.push(graphData[p]);     
        series.push({ name: p, data: graphData[p] });
    }

    $('#statChart').highcharts({
        chart: {
            type: 'spline',
            backgroundColor:"#A3A3A3"
        },
        title: {
            text: 'Weely Stats Comparison'
        },
        
        xAxis: {
            type: 'linear',
            title: {
                text: 'Week'
            },
            ordinal: false,
        },
        yAxis: {
            title: {
                text: 'Total Passing yards'
            },
            min: 0
        },
        tooltip: {
            headerFormat: '<b>{series.name}</b><br>',
            pointFormat: ' {point.y:.2f} yds'
        },

        plotOptions: {
            spline: {
                marker: {
                    enabled: true
                }
            }
        },

        series: series
    });
});
*/


// for sticky table
$(function ()
{
    var args =
    {
        stickyCols: [0, 1, 2]

    }

    //var x = new StickyTables('tablePlayers', args);
});






































