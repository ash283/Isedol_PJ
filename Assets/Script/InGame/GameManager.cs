using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Command> commandList = new List<Command>();
    private IEnumerator<Command> commandIterator;

    // Start is called before the first frame update
    void Start()
    {
        //commandList = Scenario.getS1();

        commandList = CsvLoader.loadCsv();

        commandIterator = commandList.GetEnumerator();
        if (commandIterator.MoveNext())
        {
            commandIterator.Current.Invoke();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (commandIterator.MoveNext())
            {
                commandIterator.Current.Invoke();
            }
        }
       
    }
}
