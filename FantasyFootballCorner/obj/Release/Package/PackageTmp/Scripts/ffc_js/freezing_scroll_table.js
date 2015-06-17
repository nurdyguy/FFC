





var arrFST = [];


function InitFreezingScrollTable(tableID, args)
{
    $table = $('#' + tableID);
    arrFST.push($table);

    $table.addClass('freezing_scroll_table');

    //debugger;
    var colLeft = 0;
    var rowTop = 0;
    $table.find('th.frozenColumn').each(function()
    {
        var $this = $(this);
        var colIndex = $this.parent().children().index($this);
        var colWidth = parseInt($this.css('width'));
        var rowHeight = parseInt($this.css('height'));

        console.log(colIndex + '   ' + colWidth + '  ' + colLeft + '  ' + rowHeight);

        $this.addClass('frozen').css('left', colLeft);
        $table.find('tr').each(function ()
        {
            
            $(this).find('td').eq(colIndex).addClass('frozen info').css('left', colLeft).css('top', 41);

            rowTop += rowHeight;
        });


        colLeft += colWidth;
    });


    
    $table.closest('div').on('scroll', function (e)
    {
        console.log($(e.target).scrollLeft());
        //debugger;
        console.log($table.find('th').eq(0).css('left'));

        //$table.find('th').eq(0).scrollLeft(0);

    });
    

}





