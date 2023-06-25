using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Do you like soccer :)

You have a result table for several teams, and there is also a 
face-to-face match result. You need to write a method to return 
the new table after applying the result in the table.

The table is like this:

TeamName Game Win Draw Loss  Point
----------------------------------
Arsenal   3    2   0    1     6
City      5    2   2    1     8
Rome      1    0   1    0     1
The new result is in this String form:

"Arsenal 0:2 Rome"
The new table should be like this:

Arsenal   4    2   0    2     6
City      5    2   2    1     8
Rome      2    1   1    0     4
The winner get 3 points Draw gives both teams 1 points

TableRow is class like this:

public class TableRow
    {
        public string TeamName { get; set; }
        public int Game { get; set; }
        public int Point { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Loss { get; set; }
    }
You don't need to rank them in the return table.
*/
public class TableRow
{
    public string TeamName { get; set; }
    public int Game { get; set; }
    public int Point { get; set; }
    public int Win { get; set; }
    public int Draw { get; set; }
    public int Loss { get; set; }
}

internal class Task_18
{
    public static List<TableRow> InjectNewResult(string newResult, List<TableRow> table)
    {
        List<TableRow> newTable = table;
        string[] teams = newResult.Split(' ');
        string[] score = teams[1].Split(':');
        TableRow firstTeam = new TableRow();
        TableRow secondTeam = new TableRow();
        foreach (var item in table)
        {
            if (item.TeamName == teams[0])
            {
                firstTeam = item;
            }
            if (item.TeamName == teams[2])
            {
                secondTeam = item;
            }
        }

        firstTeam.Game += 1;
        secondTeam.Game += 1;

        if (int.Parse(score[0]) > int.Parse(score[1]))
        {
            firstTeam.Point += 3;
            firstTeam.Win += 1;
            secondTeam.Loss += 1;
        }
        else if (int.Parse(score[0]) < int.Parse(score[1]))
        {
            secondTeam.Point += 3;
            firstTeam.Loss += 1;
            secondTeam.Win += 1;
        }

        else
        {
            firstTeam.Point += 1;
            secondTeam.Point += 1;
            firstTeam.Draw += 1;
            secondTeam.Draw += 1;
        }

        for (int i = 0; i < newTable.Count; i++)
        {
            if (newTable[i].TeamName == firstTeam.TeamName)
            {
                newTable[i] = firstTeam;
            }
            if (newTable[i].TeamName == secondTeam.TeamName)
            {
                newTable[i] = secondTeam;
            }
        }

        return newTable;
    }
}

