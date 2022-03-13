using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : Command
{
    public SoundManager.AUDIO audio;

    public PlaySound(SoundManager.AUDIO audio)
    {
        this.audio = audio;
    }

    public override void Invoke()
    {
        ComponentStore.soundManager.playAudio(audio);
    }
}
