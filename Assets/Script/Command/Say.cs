using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say : Command
{
    string speaker;
    string content;

    public Say(string speaker, string content)
    {
        this.speaker = speaker;
        this.content = content;
    }

    public override void Invoke()
    {
        ComponentStore.textDisplayer.setText(speaker, content);
    }
}
