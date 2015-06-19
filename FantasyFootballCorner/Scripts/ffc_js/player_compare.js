

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



//$(this).next('td').find('tbody').toggle();


function ExpandStatRow(ptr)
{
    var $row = $(ptr);
    $row.removeClass("expandDown").addClass("collapseUp");
    var $table = $row.next('td').find('div.divStatTableWeeklyData').find('table');
    debugger;
    if (!($('#tablePlayers').hasClass('ajaxLoaded') || $('#tablePlayers').hasClass('ajaxLoading')))
    {
        
        GetWeekStatsData($table);
    }
    else
    {
        if (!$table.hasClass('loaded'))
            LoadWeekStats($table);
        $table.closest('tbody').show();
    }


}


function GetWeekStatsData($table)
{
    var timer = new Date();
    $('#tablePlayers').addClass('ajaxLoading');
    $table.addClass('loading');
    var p = [];
    for (var pid in arrPlayers)
    {
        p.push({playerId: pid, position: arrPlayers[pid].position});
    }
    
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
            console.log("GetWeekStatsData response: " + (new Date() - timer));
            // parse the data
            ParseWeekStatsData(retObj);
            // set parent table to show ajax was done
            $('#tablePlayers').addClass('ajaxLoaded')
            // load and display clicked table
            LoadWeekStats($table);
        },
        error: function (retObj)
        {
            console.log('Error in GetWeekStatsData AJAX request');
        },
        complete: function ()
        {
            $('#tablePlayers').removeClass('ajaxLoading')
        }
    });


}

function ParseWeekStatsData(retObj)
{
    // build arrCats for that position
    for (var i in retObj.cats)
    {
        arrCats.push({'id': retObj.cats[i].id, 'name': retObj.cats[i].shortName});
    }
    // add all categories in arrPlayers for that position 
    for(var pid in arrPlayers)
    {
        for(var w = 1; w <= 17; w++)
        {
            arrPlayers[pid].stats[w] = {};
            for(var c in retObj.cats)
                arrPlayers[pid].stats[w][retObj.cats[c]] = 0;
        }
    }
    // parse stats
    for (var i in retObj.stats)
    {
        if (retObj.stats[i].length > 0)
        {
            var pid = retObj.stats[i][0].playerId;
            for (var j in retObj.stats[i])
            {
                if (typeof arrPlayers[pid].stats[retObj.stats[i][j].weekNum] == 'undefined')
                    arrPlayers[pid].stats[retObj.stats[i][j].weekNum] = {};
                arrPlayers[pid].stats[retObj.stats[i][j].weekNum][retObj.stats[i][j].statNum] = retObj.stats[i][j].statValue;
            }
        }
    }
}

function LoadWeekStats($table)
{
    var statType;
    debugger;

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






































