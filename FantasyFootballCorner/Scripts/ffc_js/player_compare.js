

// load compare blocks
$(function ()
{    
    LoadPlayerBackgrounds();
    LoadAggStats();
});

function LoadPlayerBackgrounds()
{
    var $block;
    for (var i = 0; i < arrPlayers.length; i++)
    {
        $block = $('#player_' + i);
        $block.find('div.comparePlayerName').text(arrPlayers[i].name);
        $block.find('div.comparePlayerImage').html('<img src="' + arrPlayers[i].pic + '" />');
        $block.find('td.tdCollege').text(arrPlayers[i].college);
        $block.find('td.tdYears').text(arrPlayers[i].years);
        $block.find('td.tdDob').text(arrPlayers[i].dob);
        $block.find('td.tdHeight').text(parseInt(arrPlayers[i].height / 12) + ' ft  ' + arrPlayers[i].height % 12 + ' in');
        $block.find('td.tdWeight').text(arrPlayers[i].weight + ' lbs');
        $block.css('display', 'inline-block');
    }
}

function LoadAggStats()
{
    $('tr.statRow').each(function ()
    {
        var $this = $(this);
        var statId = $this.attr('statId');
        var html = '<td>Season Total:</td>';
        
        for (var i = 0; i < arrPlayers.length; i++)
        {
            html += '<td class="stat">' + arrPlayers[i].stats['totals'][statId] + '</td>';
        }
        for (var j = arrPlayers.length; j < 5; j++)
        {
            html += '<td></td>';
        }
        html += '</tr>';
        $this.find('thead').find('tr.success').html(html);
    });
}



function ExpandStatRow(ptr)
{
    var $row = $(ptr);
    if($row.hasClass("expandDown"))
        $row.removeClass("expandDown").addClass("collapseUp");
    else
        $row.removeClass("collapseUp").addClass("expandDown");
    var $table = $row.next('td').find('div.divStatTableWeeklyData').find('table');

    if (!($('#tablePlayers').hasClass('ajaxLoaded') || $('#tablePlayers').hasClass('ajaxLoading')))
    {       
        GetWeekStatsData($table);
    }
    else
    {
        if (!$table.hasClass('loaded'))
            LoadWeekStats($table);
        else
            $table.closest('tbody').toggle();
    }

}


function GetWeekStatsData($table)
{
    var timer = new Date();
    $('#tablePlayers').addClass('ajaxLoading');
    $table.addClass('loading');
    var p = [];
    for (var i = 0; i < arrPlayers.length; i++)
    {
        p.push({playerId: arrPlayers[i].playerId, position: arrPlayers[i].position});
    }
    
    p = JSON.stringify(p);
    //var url = 'http://localhost:49163/Player/CompareWeeklyStats';
    var url = 'http://www.fantasyfootballcorner.com/Player/CompareWeeklyStats';
    $.ajax(
    {
        url: url,
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
        arrCats.push({ 'id': retObj.cats[i].statId, 'name': retObj.cats[i].shortName });

    }

    // add all categories in arrPlayers for that position 
    for (var i = 0; i < arrPlayers.length; i++)
    {
        for(var w = 1; w <= 17; w++)
        {
            arrPlayers[i].stats[w] = {};
            for(var c in arrCats)
                arrPlayers[i].stats[w][arrCats[c].id] = 0;
        }
    }
   
    // parse stats
    for (var i in retObj.stats)
    {
        if (retObj.stats[i].length > 0)
        {
            var index;
            for (var j = 0; j < arrPlayers.length; j++)
                if (arrPlayers[j].playerId == retObj.stats[i][0].playerId)
                    index = j;
            for (var k in retObj.stats[i])
            {               
                arrPlayers[index].stats[retObj.stats[i][k].weekNum][retObj.stats[i][k].statId] = retObj.stats[i][k].statAmt;
            }
        }
    }
}

function LoadWeekStats($table)
{
    var statId = $table.closest('tr.statRow').attr('statId');
    var html = '';
    for (var w = 1; w <= 17; w++)
    {
        html += '<tr><td>' + 'Week ' + w + '</td>';
        for (var i = 0; i < arrPlayers.length; i++)
        {
            html += '<td class="stat">' + arrPlayers[i].stats[w][statId] + '</td>';
        }
        for (var j = arrPlayers.length; j < 5; j++)
        {
            html += '<td></td>';
        }
        html += '</tr>';
    }
    $table.find('tbody').html(html);
    $table.addClass('loaded');


    $table.closest('tbody').show();
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






































