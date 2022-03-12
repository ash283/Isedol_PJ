using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextDisplayer textDisplayer = FindObjectOfType<TextDisplayer>();
        foreach (var script in new CsvLoader().loadCsv())
        {
            textDisplayer.setText(script.speaker, script.content);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
