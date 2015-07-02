


$(function ()
{
    var tableLen = arrPlayers.length;

    if (tableLen <= numRows)
    {
        $('#pager').hide();
    }
    else
    {
        currPage = 1;
    }

    BindEvents();

});

/*
$(function () {
    var args = {};
    InitFreezingScrollTable('tablePlayers', args);

});
*/

function Pager(dir)
{
    var $pager = $('#pager');
    switch (dir)
    {
        case 'first':
            if (currPage > 1)
            {
                currPage = 1;
            }
            break;
        case 'prev':
            if (currPage > 1)
            {
                currPage--;
            }
            break;
        case 'next':
            if (currPage < arrPlayers.length/numRows + 1)
            {
                currPage++;       
            }
            break;
        case 'last':
            if (currPage < arrPlayers.length / numRows + 1)
            {
                currPage = parseInt(arrPlayers.length / numRows) + 1;
            }
            break;
    }

    var startIndex = (currPage - 1) * numRows;

    if (currPage == 1)
    {
        $pager.find('li').eq(0).addClass('disabled');
        $pager.find('li').eq(1).addClass('disabled');
    }
    else
    {
        $pager.find('li').eq(0).removeClass('disabled');
        $pager.find('li').eq(1).removeClass('disabled');
    }

    if (currPage == parseInt(arrPlayers.length / numRows) + 1)
    {
        $pager.find('li').eq(2).addClass('disabled');
        $pager.find('li').eq(3).addClass('disabled');
    }
    else
    {
        $pager.find('li').eq(2).removeClass('disabled');
        $pager.find('li').eq(3).removeClass('disabled');
    }

    RebuildPlayerTable(startIndex);
}


// globals for drag events
var dragging = false;
var dragPID = -1;
var dragIndex = -1;
var $dragImage;

function BindEvents()
{
    $dragImage = $('#imgPlayerDrag');
    $('img.dragIcon').on('mousedown', function (e)
    {
        
        e.preventDefault();
        dragPID = $(this).closest('tr').attr('pid');
        dragIndex = $(this).closest('tr').attr('pIndex');
        var found = false
        for (var i = 0; i < arrPlayers.length && !found; i++)
            if (arrPlayers[i].playerId == dragPID)
            {
                dragIndex = i;
                found = true;
            }
        var firstEmpty = -1;
        for (var i = 0; i < 5 && firstEmpty < 0; i++)
        {
            if (!$('#playerCompare_' + i).hasClass('hasPlayer'))
                firstEmpty = i;
        }
        if (firstEmpty >= 0)
        {

            dragging = true;
            $dragImage.closest('div').show();
            $dragImage.prop('src', arrPlayers[dragIndex].pic);
            $dragImage.css('top', e.pageY - 2).css('left', e.pageX - 32);

        }
    });

    $(body).on('mouseup', '#divComparePlayers', function (e)
    {
        // exit if invalid drag
        if (!dragging || dragPID < 0)
            return;

        var $block = $(e.target).closest('div.playerCompareBlock');

        for (var i = 0; i < 5; i++)
        {
            var pid = $('div.playerCompareBlock').eq(i).attr('pid');
            var pIndex = $('div.playerCompareBlock').eq(i).attr('pIndex');
            if (pid > 0 && arrPlayers[dragIndex].position != arrPlayers[pIndex].position)
            {
                alert('You cannot compare players from different positions.');
                dragPID = -1;
                dragIndex = -1;
                dragging = false;

                $dragImage.closest('div').hide();
                return;
            }

            if (pid == dragPID)
            {
                alert('Player already on list.');
                dragPID = -1;
                dragIndex = -1;
                dragging = false;

                $dragImage.closest('div').hide();
                return;
            }
        }

        var img = '<img src="' + arrPlayers[dragIndex].pic + '" class="comparePlayerImage" width="150" height="150"/>';
        $block.attr('PID', dragPID);
        $block.attr('pIndex', dragIndex);
        $block.find('div.comparePlayerName').text(arrPlayers[dragIndex].name + ' - ' + arrPlayers[dragIndex].position);
        $block.find('div.comparePlayerImage').html(img);
        $block.addClass('hasPlayer');
        $block.find('a.compareRemoveButton').show();
        $block.find('input').val(dragPID);

        dragPID = -1;
        dragging = false;

        $dragImage.closest('div').hide();
    });

    $(body).on('mousemove', function (e)
    {
        if (!dragging)
            return;
        $dragImage.css('top', e.pageY - 2).css('left', e.pageX - 32);
    });

    $('a.compareRemoveButton').on('click', function (e)
    {
        var $block = $(e.target).closest('div.playerCompareBlock');
        var html = '<div class="divDropHere">Drop Player Here</div>';

        $block.attr('PID', -1);
        $block.attr('pIndex', -1);
        $block.find('div.comparePlayerName').text('');
        $block.find('div.comparePlayerImage').html(html);
        $block.removeClass('hasPlayer');
        $block.find('a.compareRemoveButton').hide();
        $block.find('input').val(-1);
    });
}





function Sort(ptr)
{
    var $this = $(ptr);
    var sortCat = $this.attr('sortCat');
    var sortClass = 'sortedDesc';
    if ($this.find('span').hasClass('sortedDesc'))
    {
        sortClass = 'sortedAsc';
    }
    $('span.sortedAsc , span.sortedDesc').removeClass('sortedAsc').removeClass('sortedDesc');

    if (sortCat == 'name' || sortCat == 'position' || sortCat == 'team')
    {
        if (sortClass == 'sortedAsc')
            arrPlayers.sort(function (a, b)
            {
                return a[sortCat].localeCompare(b[sortCat]);
            });
        else
            arrPlayers.sort(function (a, b)
            {
                return b[sortCat].localeCompare(a[sortCat]);
            });
    }
    else
    {
        if (sortClass == 'sortedAsc')
            arrPlayers.sort(function (a, b)
            {
                return a['stats'][sortCat] - b['stats'][sortCat];
            });
        else
            arrPlayers.sort(function (a, b)
            {
                return b['stats'][sortCat] - a['stats'][sortCat];
            });
    }
    $this.find('span').addClass(sortClass);
    Pager('first');
}

function RebuildPlayerTable(startIndex)
{
    var $table = $('#tablePlayers').find('tbody');
    var rows = '';
    for (var i = startIndex; i < startIndex + numRows && i < arrPlayers.length; i++)
    {
        rows += '<tr class="success ui-dragable playerRow" pid=' + arrPlayers[i].playerId + ' pIndex=' + i + '>';
        rows += '<td ><img class="dragIcon" src="/images/drag_arrow-hi.png" height="25" width="25" /></td>';
        rows += '<td >' + arrPlayers[i].name + '</td>';
        rows += '<td >' + arrPlayers[i].position + '</td>';
        rows += '<td >' + arrPlayers[i].team + '</td>';
        for(var cat in arrPlayers[i].stats)
        {
            rows += '<td >' + arrPlayers[i].stats[cat] + '</td>';
        }
        rows += '</tr>';
    }
    $table.html(rows);
}