using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// actionNuber
/// 0 - Say
/// 1 - Play Sound
/// 2 - Show Phone
/// 3 - Transition01
/// 4 - Hide Phone
/// 5 - FadeIn
/// 6 - FadeOut
/// 7 - Show Character
/// 8 - Hide Character
/// 9 - Change Background
///
/// parameter
/// Button, Bell, Phone ring, 
/// </summary>
public class CsvRow
{
    public CsvRow(string speaker, string content, int actionCode, string parameter)
    { 
        this.speaker = speaker;
        this.content = content;
        this.actionCode = actionCode;
        this.parameter = parameter;
    }
  
    public string speaker;
    public string content;
    public int actionCode;
    public string parameter;
}

public static class CsvLoader
{
    public static List<Command> loadCsv()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Stroy/main");
        string[] lineList = textAsset.text.Split('\n');
        List<CsvRow> rows = new List<CsvRow>();

        for(int i = 1; i < lineList.Length; i++)
        { 
            string[] datas = lineList[i].Split(',');
            //if (datas.Length < 2)
            //{
            //    continue;
            //}

            rows.Add(new CsvRow(datas[0], datas[1], int.Parse(datas[2]), datas[3]));
        }
       

        List<Command> result = parseCsv(rows);


        return result;

    }

    public static List<Command> parseCsv(List<CsvRow> rowList)
    {
        List<Command> result = new List<Command>();

        foreach(var row in rowList)
        {
            switch (row.actionCode)
            {
                case 0:
                    result.Add(new Say(row.speaker, row.content));
                    break;
                
            }
        }

        return result;
    }
}
