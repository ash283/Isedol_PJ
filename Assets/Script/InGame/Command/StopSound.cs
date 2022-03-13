using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : Command
{
    public override void Invoke()
    {
        ComponentStore.soundManager.stopSound();
    }
}
