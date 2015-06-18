





var html = 
'<td >
    @Html.ActionLink(item.player.playerName, "Details", new { id = item.player.playerId }, new { @class = "detailsLink" })
</td>
<td>
    @Html.DisplayFor(modelItem => item.player.position)
</td>
<td>
    @(item.team.geoName + " " + item.team.teamName)
</td>
<td>
    @(item.weekStat.season + " week " + item.weekStat.weekNum)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_2)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_3)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_4)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_5)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_6)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_7)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_8)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_9)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_10)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_11)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_12)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_13)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_14)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_15)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_16)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_17)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_18)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_19)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_20)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_21)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_22)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_23)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_24)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_25)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_26)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_27)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_28)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_29)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_30)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_31)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_32)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_33)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_34)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_35)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_36)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_37)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_38)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_39)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_40)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_41)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_42)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_43)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_44)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_45)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_46)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_47)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_48)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_49)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_50)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_51)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_52)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_53)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_54)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_55)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_56)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_57)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_58)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_59)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_60)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_61)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_62)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_63)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_64)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_65)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_66)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_67)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_68)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_69)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_70)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_71)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_72)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_73)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_74)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_75)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_76)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_77)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_78)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_79)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_80)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_81)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_82)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_83)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_84)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_85)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_86)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_87)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_88)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_89)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_90)
</td>
<td>
    @Html.DisplayFor(modelItem => item.weekStat.statCat_91)
</td>'


var header =
'<th >
    @Html.DisplayNameFor(model => model.player.playerName)
</th>
<th >
    @Html.DisplayNameFor(model => model.player.position)
</th>
<th>
    @Html.DisplayNameFor(model => model.team.teamName)
</th>               
<th>
    Season - Week
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_2)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_3)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_4)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_5)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_6)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_7)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_8)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_9)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_10)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_11)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_12)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_13)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_14)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_15)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_16)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_17)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_18)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_19)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_20)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_21)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_22)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_23)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_24)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_25)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_26)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_27)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_28)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_29)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_30)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_31)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_32)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_33)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_34)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_35)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_36)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_37)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_38)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_39)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_40)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_41)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_42)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_43)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_44)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_45)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_46)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_47)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_48)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_49)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_50)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_51)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_52)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_53)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_54)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_55)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_56)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_57)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_58)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_59)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_60)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_61)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_62)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_63)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_64)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_65)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_66)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_67)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_68)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_69)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_70)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_71)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_72)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_73)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_74)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_75)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_76)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_77)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_78)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_79)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_80)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_81)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_82)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_83)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_84)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_85)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_86)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_87)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_88)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_89)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_90)
</th>
<th>
    @Html.DisplayNameFor(model => model.weekStat.statCat_91)
</th>















