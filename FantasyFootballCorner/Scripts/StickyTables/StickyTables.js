




var arrStickyTables = [];

function StickyTables(id, args)
{
    var timer = new Date();
    this.$table = $('#' + id);
    if (this.$table.length == 0)
        return;

    this.props = args;
    this.attr = {
        stickyHeight: 0,
        stickyWidth: 0
    };

    arrStickyTables.push(this);

    this.InitTable();
    console.log(new Date() - timer);
}

StickyTables.prototype.InitTable = function()
{
    this.$table.wrap('<div class="stickyDivWrapper" ></div>');
    this.$table.wrap('<div class="stickyDivScroll" ></div>');
    this.$table.addClass('stickyTable');
    if (typeof this.props.stickyHeader != 'undefined' && this.props.stickHeader == true)
    {
        this.$table.find('thead').find('tr').addClass('stickyRow');
        this.attr['stickyHeight'] += this.$table.find('thead').find('tr').css('height');
    }

    if (typeof this.props.stickyRows != 'undefined' && Array.isArray(this.props.stickyRows))
    {
        for (var i = 0; i < this.props.stickyRows.length; i++)
        {
            this.$table.find('tbody').find('tr').eq(i).addClass('stickyRow');
            this.attr['stickyHeight'] += parseInt(this.$table.find('tbody').find('tr').css('height'), 10);
        }
    }

    if (typeof this.props.stickyCols != 'undefined' && Array.isArray(this.props.stickyCols))
    {
        for (var i = 0; i < this.props.stickyCols.length; i++)
        {
            this.$table.find('tbody').find('tr').find('td').eq(i).addClass('stickyCol');
            this.attr['stickyWidth'] += parseInt(this.$table.find('tbody').find('tr').find('td').eq(i).css('width'),10);
        }
    }

    this.origTableHtml = this.$table.html();

    this.CalcLeftTable();
    //this.ConvertTableToDivs();

}

StickyTables.prototype.CalcLeftTable = function ()
{
    //debugger;
    var self = this;
    var leftTable = '';

    var $thead = this.$table.find('thead');

    if ($thead.length > 0)
        leftTable = this.$table[0].outerHTML.substring(0, this.$table[0].outerHTML.indexOf('<thead'));
    else
        if ($tbody.length > 0)
            leftTable = this.$table[0].outerHTML.substring(0, this.$table[0].outerHTML.indexOf('<tbody'));
        else
            return false;

    if ($thead.length > 0)
    {
        var head = $thead[0].outerHTML.substring(0, $thead[0].outerHTML.indexOf('<tr'));
        $thead.find('tr').each(function ()
        {
            var $tr = $(this);
            head += $tr[0].outerHTML.substring(0, $tr[0].outerHTML.indexOf('<th'));
            for (var col in self.props.stickyCols)
            {
                head += $tr.find('th').eq(col)[0].outerHTML;
            }
            head += '</tr>';
        });
        head += '</thead>';
    }

    var $tbody = this.$table.find('tbody');
    if ($tbody.length > 0)
    {
        var body = $tbody[0].outerHTML.substring(0, $tbody[0].outerHTML.indexOf('<tr'));
        $tbody.find('tr').each(function ()
        {
            var $tr = $(this);
            body += $tr[0].outerHTML.substring(0, $tr[0].outerHTML.indexOf('<td'));
            for (var col in self.props.stickyCols)
            {
                body += $tr.find('td').eq(col)[0].outerHTML;
            }
            body += '</tr>';
        });
        body += '</body>';
    }

    leftTable += head + body + '</table>';
    //console.log(leftTable);
    this.$table.closest('div.stickyDivWrapper').append(leftTable);
    this.$leftTable = this.$table.closest('div.stickyDivWrapper').find('table').last();
    this.$leftTable.addClass('stickyLeftTable').removeClass('stickyTable');
    //this.$leftTable.find('tbody').find('tr').removeClass('success').addClass('info');
    this.$leftTable.css('width', this.attr.stickyWidth);
    
}










StickyTables.prototype.ConvertTableToDivs = function ()
{
    debugger;


}

















