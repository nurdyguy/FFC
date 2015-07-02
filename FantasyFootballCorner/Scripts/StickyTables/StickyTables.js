




var arrStickyTables = [];

function StickyTables(id, args)
{
    var timer = new Date();
    this.$table = $('#' + id);

    
    if (this.$table.length == 0 || typeof args == 'undefined')
        return;

    arrStickyTables.push(this);

    // default prop values-- these are settings passed in by user
    this.prop = {
        stickyCols: 0,                  // number of sticky columns
        stickyRows: 0,                  // number of sticky rows
        stickyColLock: 'left',          // lock columns from left or right
        stickyRowLock: 'top',           // lock rows from top or bottom
        stickyHeader: false,            // use sticky header --- if stickyCols > 0 then this is true
        horizScroll: false,             // use horizontal scrolling
        vertScroll: false,              // use vertical scrolling

        colorStickyCols: false,          // false or #hex color
        stickyColColor: '#000000',        
        colorStickyRows: false,          // false or #hex color
        stickyRowColor: '#000000',

        borderStickyCols: false,
        stickyColBorderColor: '#000000',
        stickyColBorderThickness: 0,
        borderStickyRows: false,
        stickyRowBorderColor: '#000000',
        stickyRowBorderThickness: 0,


        paging: {
            isActive: false,
            numRows: 25,
            useFirst: true,
            useLast: true,
            useNext: true,
            usePrev: true,
            
            useGoTo: true,
            goToType: 'buttons',
            goToTypeArr: { 'buttons': null, 'select': null }
        },

        sorting: {
            isActive: false,
            sortAllCols: false,
            sortCols: [0],
            firstClick: 'ascending',
            ascArrowImg: '',
            descArrowDownImg: ''
        }
    };



    this.ParseProps(args);

    // default attribute values-- calculated values based on properties
    this.attr = {
        stickyHeight: 0,
        stickyWidth: 0
    };



    this.InitTable();

    if (this.prop.paging.isActive)
        this.InitPager();

    if (this.prop.sorting.isActive)
        this.InitSorter();

    console.log(new Date() - timer);
}

StickyTables.prototype.ParseProps = function (args)
{
    // lazy parser
    for (var p in args)
        if (typeof this.prop[p] != 'undefined' && typeof args[p] == typeof this.prop[p])
        {
            switch (p)
            {
                case 'stickyColLock':
                    if (args.p == 'left' || args.p == 'right')
                        this.prop[p] = args[p];
                    else
                        console.log('Invalid value for attribute: ' + p);
                    break;
                case 'stickyRowLock':
                    if (args[p] == 'top' || args[p] == 'bottom')
                        this.prop[p] = args[p];
                    else
                        console.log('Invalid value for attribute: ' + p);
                    break;
                case 'paging':
                    this.prop.paging.isActive = true;
                    for (var p2 in args[p])
                        if (typeof this.prop[p][p2] != 'undefined' && typeof args[p][p2] == typeof this.prop[p][p2])
                        {
                            switch (p2)
                            {
                                case 'goToType':
                                    if (p2 in this.prop.paging.goToTypeArr)
                                        this.prop[p][p2] = args[p][p2];
                                    else
                                        console.log('Invalid value for attribute: ' + p);
                                    break;
                                default:
                                    this.prop[p][p2] = args[p][p2];
                            }
                        }
                    break;
                case 'sorting':
                    this.prop.sorting.isActive = true;
                    for (var p2 in args[p])
                        if (typeof this.prop[p][p2] != 'undefined' && typeof args[p][p2] == typeof this.prop[p][p2])
                        {
                            switch (p2)
                            {


                                default:
                                    this.prop[p][p2] = args[p][p2];
                            }
                        }
                    break;
                default:
                    this.prop[p] = args[p];
            }

        }

            /*
            case 'stickyColBorderColor':
                    var maxStrLen = 7;
                    if (typeof args.p == 'string')
                    {
                        if(args.p.indexOf('#') == -1)
                            maxStrLen = 6;
                        if(args.p.length <= maxStrLen)
                            this.prop.p = args.p;
                        else
                            console.log('Invalid value for attribute: ' + p);
                    }
                    else
                        console.log('Invalid value for attribute: ' + p);
                    break;
                case 'stickyRowBorderColor':
                    var maxStrLen = 7;
                    if (typeof args.p == 'string')
                    {
                        if (args.p.indexOf('#') == -1)
                            maxStrLen = 6;
                        if (args.p.length <= maxStrLen)
                            this.prop.p = args.p;
                        else
                            console.log('Invalid value for attribute: ' + p);
                    }
                    else
                        console.log('Invalid value for attribute: ' + p);
                    break;
                */
            
        

}

StickyTables.prototype.InitTable = function()
{
    this.$table.wrap('<div class="stickyDivWrapper" ></div>');
    this.$table.wrap('<div class="stickyDivScroll" ></div>');
    this.$table.addClass('stickyTable');
    if (this.prop.stickHeader == true)
    {
        this.$table.find('thead').find('tr').addClass('stickyRow');
        this.attr['stickyHeight'] += this.$table.find('thead').find('tr').css('height');
    }

   
    for (var i = 0; i < this.prop.stickyRows; i++)
    {
        this.$table.find('tbody').find('tr').eq(i).addClass('stickyRow');
        this.attr['stickyHeight'] += parseInt(this.$table.find('tbody').find('tr').css('height'), 10);
    }
    

    for (var i = 0; i < this.prop.stickyCols; i++)
    {
        this.$table.find('tbody').find('tr').find('td').eq(i).addClass('stickyCol');
        this.attr['stickyWidth'] += parseInt(this.$table.find('tbody').find('tr').find('td').eq(i).css('width'),10);
    }
    

    this.origTableHtml = this.$table.html();

    //this.CalcLeftTable();

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


StickyTables.prototype.InitPager = function ()
{


}


StickyTables.prototype.InitSorter = function ()
{


}























