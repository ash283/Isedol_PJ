using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsvLoader
{
    public List<Script> loadCsv()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Stroy/main");
        List<Script> result = new List<Script>();
        string[] lineList = textAsset.text.Split('\n');
        foreach (var line in lineList)
        {
            string[] datas = line.Split(',');
            if(datas.Length < 2)
            {
                continue;
            }
          
            result.Add(new Script(datas[0], datas[1]));
        }

        if (result.Count > 0)
        {
            result.RemoveAt(0);
        }

        return result;

    }
}
