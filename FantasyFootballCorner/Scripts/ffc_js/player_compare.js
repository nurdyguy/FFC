

// load compare blocks
$(function ()
{
    
    for (var pid in arrPlayers)
    {
        


        /*
        for (var stat in arrPlayers[pid].stats)
        {
            $('div.

        }
        break;
        */
    }



});



$(this).next('td').find('tbody').toggle();


function ExpandStatRow(ptr)
{
    var $row = $(this);
    $row.removeClass("expandDown").addClass("collapseUp");

    var $table = $row.next('td').find('tbody').show().find('table');

    if (!($table.hasClass('alreadyLoaded') || $table.hasClass('loading')))
    {
        GetWeekStatsData();
    }



}


function GetWeekStatsData()
{
    var p = [];
    for (var pid in arrPlayers)
    {
        p.push({playerId: pid, position: arrPlayers[pid].position});
    }
    debugger;
    p = JSON.stringify(p);

    $.ajax(
    {
        url: 'http://localhost:49163/Player/CompareWeeklyStats',
        type: "POST",
        async: true,
        data: p,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj)
        {
            debugger;
        },
        error: function (retObj)
        {
            debugger;
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function ()
        {
            

        }
    });


}


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






































