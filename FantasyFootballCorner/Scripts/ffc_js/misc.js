


function GetWikiBio(arrPlayers) 
{
    
        
    var players = '';
    for (var i = notFound; i < 30 && i < arrPlayers.length; i++)
    {
        if(i > 0)
            players+= '|';
        players += arrPlayers[i].name.replace(' ', '_');
    }
    console.log(players);
    
    var URL = 'http://en.wikipedia.org/w/api.php?action=query&prop=revisions&rvprop=content&format=json&titles=' + players;
    $.ajax(
    {
        // gets season stats
        url: URL,
        type: "POST",
        dataType: 'jsonp',
        success: function (retObj)
        {
            PostWikiBio(retObj, arrPlayers);
        },
        error: function (retObj)
        {
            alert('error in api retrievel');
        },
        complete: function ()
        {

        }
    });
}



function PostWikiBio(retObj, arrPlayers)
{
   
    var p = new Array();
    for (var obj in retObj.query.pages)
    {
        if (obj != -1)
        {
            var outArr = retObj.query.pages[obj].revisions[0]['*'].split('\n|');
            var outArr2 = [];
            if (outArr[0].indexOf('may refer to:') < 0)
            {
                for (var i = 0; i < outArr.length; i++)
                {
                    var name = outArr[i].substring(outArr[i].indexOf('=') + 1);
                    if (name.charAt(0) == ' ')
                        name = name.substring(1);
                    outArr2[outArr[i].substring(0, outArr[i].indexOf('=')).split(' ').join('')] = name;
                }
                var found = false;
                var id = -1;
                for (var i = 0; i < arrPlayers.length && !found; i++)
                {
                    if (arrPlayers[i].name == outArr2['name'])
                    {
                        id = arrPlayers[i].playerId;
                        arrPlayers.splice(i, 1);
                    }
                }

                if(typeof  outArr2['image'] == 'undefined')
                    var imageURL = '';
                else
                    var imageURL = outArr2['image'].split(' ').join('_');
                if (typeof outArr2['DATEOFBIRTH'] == 'undefined')
                    var DOB = null;
                else
                    var DOB = outArr2['DATEOFBIRTH'];
                if (typeof outArr2['heightft'] == 'undefined' || typeof outArr2['heightin'] == 'undefined')
                    var height = null;
                else
                    var height =  outArr2['heightft'] * 12 + outArr2['heightin'] * 1;
                if (typeof outArr2['weight'] == 'undefined')
                    var weight = null;
                else
                    var weight = outArr2['weight'];
                if (typeof outArr2['highschool'] == 'undefined')
                    var hs = '';
                else
                    var hs = outArr2['highschool'];
                if (typeof outArr2['college'] == 'undefined')
                    var college = '';
                else
                    var college = outArr2['college'];
                if (typeof outArr2['draftyear'] == 'undefined')
                    var dy = null;
                else
                    var dy = outArr2['draftyear'];
                if (typeof outArr2['draftround'] == 'undefined' || typeof outArr2['heightin'] == 'draftpick')
                    var dpos = null;
                else
                    var dpos = outArr2['draftround'] + '/' + outArr2['draftpick'];
                if (id > 0)
                {
                    p.push({
                        playerID: id,
                        name: outArr2['name'],
                        imageUrl: imageURL,
                        dob: DOB,
                        height: height,
                        weight: weight,
                        highSchool: hs,
                        college: college,
                        draftYear: dy,
                        draftPos: dpos
                    });
                }
                else
                {
                    notFound++;
                }
            }       
        
        }
        
    }
    console.log(p);

    p = JSON.stringify(p);

    $.ajax(
    {
        url: 'http://localhost:49163/PlayerBackground/UpdatePlayerBackgrounds',
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
            
            console.log("notFound: " + notFound + "   arrPlayers.length: " + arrPlayers.length);
            if (notFound == arrPlayers.length)
            {
                alert('done');

            }
            else
            {
                GetWikiBio(arrPlayers);
            }
        }
    });


    
}