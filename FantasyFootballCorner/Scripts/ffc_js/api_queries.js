


// pulls a list of the name:id pairs from dbo.Player
function GetPlayerNamesIds(nextFun, args)
{
    $.ajax(
    {
        url: 'http://localhost:49163/Player/NameList',
        type: "POST",
        async: true,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj)
        {		
			args.localPlayers = retObj;
			if(typeof nextFun != 'undefined')
				nextFun(args);	
        },
        error: function (retObj)
        {
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function ()
        {
            //alert('done');

        }
    });

}

function GetNFLPlayers(nextFun, args)
{
		
	$.ajax(
    {
        //url: 'http://api.fantasy.nfl.com/v1/players/editordraftranks?format=json',      
		url: 'http://api.fantasy.nfl.com/v1/players/researchinfo?format=json&offset=' + args.offset,
        async: true,
        contentType: 'application/json; charset=utf-8',
		dataType: 'jsonp',
        success: function (retObj)
        {				
			args.nflPlayers = retObj.players;
            if(typeof nextFun != 'undefined')
				nextFun(args);
                        
        },
        error: function (retObj)
        {
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function ()
        {
            

        }
    });
	
	
}

// checks nfl.com for player page
function CheckNFLBio(arrPlayers, index)
{
    while (arrPlayers[index].position == 'DEF')
    {
        index++;
    }
    var playerName = arrPlayers[index].name.split(' ').join('');
    var playerID = arrPlayers[index].playerId;
    
    $.ajax(
    {
        url: 'http://www.nfl.com/player/' + playerName + '/' + playerID + '/profile',
        type: "POST",
        async: true,
        //data: p,
        contentType: 'xhtml',
        success: function (retObj)
        {
            
            ScrapeNflPage(retObj, arrPlayers, index);
            PostPlayerBackground(arrPlayers, index);
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

// scrape nfl.com player page info
function ScrapeNflPage(retObj, arrPlayers, index)
{
    var x = retObj.indexOf('"player-photo">');
    retObj = retObj.substring(x + 15);
    x = retObj.indexOf('<img src="');
    retObj = retObj.substring(x + 10)
    var imageURL = retObj.substring(0, retObj.indexOf('"'));

    x = retObj.indexOf('<strong>Height</strong>: ');
    retObj = retObj.substring(x + 25);
    var height = retObj.substring(0, retObj.indexOf('&nbsp;'));
    height = parseInt(height) * 12 + parseInt(height.substring(height.indexOf('-') + 1));

    x = retObj.indexOf('<strong>Weight</strong>: ');
    retObj = retObj.substring(x + 25);
    var weight = parseInt(retObj.substring(0, retObj.indexOf('&nbsp;')));

    x = retObj.indexOf('<strong>Born</strong>: ');
    retObj = retObj.substring(x + 23);
    var born = retObj.substring(0, retObj.indexOf(' '));

    x = retObj.indexOf('<strong>College</strong>: ');
    retObj = retObj.substring(x + 26);
    var college = retObj.substring(0, retObj.indexOf('</p>'));

    x = retObj.indexOf('<strong>Experience</strong>: ');
    retObj = retObj.substring(x + 29);
    var experience = parseInt(retObj.substring(0, retObj.indexOf('</p>')));

    arrPlayers[index].height = height;
    arrPlayers[index].weight = weight;
    arrPlayers[index].imageURL = imageURL;
    arrPlayers[index].dob = born;
    arrPlayers[index].college = college;
    arrPlayers[index].years = experience;

    
    
}

// post data from nfl.com to dbo.PlayerBackground
function PostPlayerBackground(arrPlayers, index)
{
    var p = JSON.stringify(arrPlayers[index]);

    $.ajax(
    {
        url: 'http://localhost:49163/PlayerBackground/UpdatePlayerBackgrounds',
        type: "POST",
        async: true,
        data: p,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj)
        {
            console.log('player: ' + arrPlayers[index].name);
        },
        error: function (retObj)
        {
            debugger;
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function ()
        {
            //return;
            // next step
            index++;
            if (index < arrPlayers.length)
                CheckNFLBio(arrPlayers, index);
        }
    });

}

function GetStatCategories()
{
    $.ajax(
    {
        url: 'http://api.fantasy.nfl.com/v1/game/stats?format=json',
        
        async: true,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj)
        {
            PostStatCategories(retObj.stats);
                        
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

function PostStatCategories(arrStatCats)
{
    

    var p = JSON.stringify(arrStatCats);

    $.ajax(
    {
        url: 'http://localhost:49163/StatCategory/UpdateStatCats',
        type: "POST",
        async: true,
        data: p,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj)
        {
            //console.log('player: ' + arrPlayers[index].name);
        },
        error: function (retObj)
        {
            debugger;
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function ()
        {
            alert('done');
        }
    });
}

function GetNFLStats(week, year) 
{   
    
    var url = 'http://api.fantasy.nfl.com/v1/players/stats?statType=weekStats&season=' + year + '&week=' + week + '&format=json';
    $.ajax(
    {
        // gets game stats definitions
        //url: 'http://api.fantasy.nfl.com/game/stats',
        //old url: 'http://api.fantasy.nfl.com/players/stats?statType=seasonStats&season=2014'
        
        // gets season stats
        url: url,
        data: {
            format: 'json'
        },
        success: function (retObj) {
            PostNFLWeekStats(retObj.players, week, year)
        },
        error: function (retObj) {
            alert('error in api retrievel');
        },
        complete: function () {
            if (week < 17)
            {
                week++;
                GetNFLStats(week, year)
            }

        }
    });

}

function PostNFLSingleStats(players, week, year)
{
    //debugger;

    var p = new Array();
    var playerId;
    for (var i = 0; i < players.length; i++)
    {
        if (players[i].position == 'QB' || players[i].position == 'WR' || players[i].position == 'RB'
            || players[i].position == 'TE' || players[i].position == 'K' || players[i].position == 'DEF')
        {
            p = [];
            playerId = players[i].id;
            for(var s in players[i].stats)
            {
                p.push({ 'statNum': s, 'statValue': players[i].stats[s], 'playerId': playerId, 'season': year, 'weekNum': week });

            }
            
            pjson = JSON.stringify(p);

            $.ajax(
            {
                url: 'http://localhost:49163/PlayerStat/CreateBulk',
                type: "POST",
                async: true,
                data: pjson,
                contentType: 'application/json; charset=utf-8',
                success: function (retObj)
                {

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
    }

}

function PostNFLPlayerInfo(retObj) 
{
    //debugger
    var p = new Array();
    for (var i = 0; i < retObj.players.length; i++)
    {
        if (retObj.players[i].position == 'K')
        {
            p.push({
                playerId: parseInt(retObj.players[i].id), name: retObj.players[i].name,
                position: retObj.players[i].position, teamAbbre: retObj.players[i].teamAbbr
            });
        }
    }

    p = JSON.stringify(p);

    $.ajax(
    {
        url: 'http://localhost:49163/Player/UpdatePlayers',
        type: "POST",
        async: true,
        data: p,
        contentType: 'application/json; charset=utf-8',
        success: function (retObj) {

        },
        error: function (retObj) {
            debugger;
            var errorMessage = retObj.responseText.title;
            alert(errorMessage);
        },
        complete: function () {
            alert('done');

        }
    });

}


// begins UpdatePlayers path
function UpdatePlayers()
{
	var nextFun1 = function(args)
	{
		ParseLocalPlayers(args);
		var nextFun2 = function(args)
		{
			ParseNFLPlayers(args);
		}
		
		args.offset = 0;
		while (args.offset < 2000)
		{	
			GetNFLPlayers(nextFun2, args);
			args.offset += 50;
		}
	}	
	var args = {};
	GetPlayerNamesIds(nextFun1, args);
}

function ParseLocalPlayers(args)
{
	// parse local players into key valued array
	var localPlayers = {};
	for(var i = 0; i < args.localPlayers.length; i++)
	{
		localPlayers[args.localPlayers[i].playerId] = args.localPlayers[i];
	}
	
	args.localPlayers = localPlayers;
	
}

function ParseNFLPlayers(args)
{
	// parse out NFL Players response and update local Players object
    var arrPID = [];
    
	for(var i = 0; i < args.nflPlayers.length; i++)
	{
		if(args.nflPlayers[i].id in args.localPlayers)
		{
			arrPID.push(args.nflPlayers[i].id);
			args.localPlayers[args.nflPlayers[i].id].playerName = args.nflPlayers[i].firstName + ' ' + args.nflPlayers[i].lastName;
			args.localPlayers[args.nflPlayers[i].id].position = args.nflPlayers[i].position;
			args.localPlayers[args.nflPlayers[i].id].teamAbbre = args.nflPlayers[i].teamAbbr;			
		}
		
	}
	
	//debugger;
	var pid = 0;
	var p = [];

	for(var i = 0; i < arrPID.length; i++)
	{
		p.push(args.localPlayers[arrPID[i]]);
	}

	if(p.length > 0)
	{
		p = JSON.stringify(p);

		$.ajax(
		{
			url: 'http://localhost:49163/Player/UpdatePlayers',
			type: "POST",
			async: true,
			data: p,
			contentType: 'application/json; charset=utf-8',
			success: function (retObj)
			{
				console.log('done with: ' + arrPID.length);
				
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
}


function UpdateWeekStats(args)
{		
	var nextFun = function(args)
	{			
		ParseLocalPlayers(args);
		GetWeekStats(args);
	}	
	
	GetPlayerNamesIds(nextFun, args);
}


function GetWeekStats(args)
{

	var url = 'http://api.fantasy.nfl.com/v1/players/stats?statType=weekStats&season=' + args.year + '&week=' + args.week + '&format=json';
    $.ajax(
    {
        // gets game stats definitions
        //url: 'http://api.fantasy.nfl.com/game/stats',
        //old url: 'http://api.fantasy.nfl.com/players/stats?statType=seasonStats&season=2014'
        
        // gets season stats
        url: url,
        async: true,
        contentType: 'application/json; charset=utf-8',
		dataType: 'jsonp',
        success: function (retObj) {
            PostNFLWeekStats(retObj.players, args)
        },
        error: function (retObj) {
            alert('error in api retrievel');
        },
        complete: function () {
            if (args.week < 17)
            {
                args.week++;
                GetWeekStats(args);
            }
			
        }
    });

}

function PostNFLWeekStats(players, args)
{
    

    var p = new Array();
    var playerId;
    for (var i = 0; i < players.length; i++)
    {
        if (players[i].position == 'QB' || players[i].position == 'WR' || players[i].position == 'RB'
					|| players[i].position == 'TE' || players[i].position == 'K' || players[i].position == 'DEF')
        {
			if(players[i].id in args.localPlayers)
			{
				p = [];
				p[0] = {'playerId': players[i].id, 'weekNum': args.week, 'season': args.year};
				for(var s in players[i].stats)
				{
					p[0]['statCat_' + s] = players[i].stats[s];
				}
			   
				pjson = JSON.stringify(p);

				$.ajax(
				{
					url: 'http://localhost:49163/WeekStat/CreateBulk',
					type: "POST",
					async: true,
					data: pjson,
					contentType: 'application/json; charset=utf-8',
					success: function (retObj)
					{

					},
					error: function (retObj)
					{
						debugger;
						var errorMessage = retObj.responseText.title;
						alert(errorMessage);
					},
					complete: function ()
					{
						console.log('posted week ' + args.week + ' of ' + args.year);

					}
				});
			}

        }
    }

}
















