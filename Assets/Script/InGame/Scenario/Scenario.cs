using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Scenario
{
    public static List<Command> getS1()
    {
        List<Command> s1 = new List<Command>();
        s1.Add(new PlaySound(SoundManager.AUDIO.FX_ALARM));
        s1.Add(new Say("주인공", "아... 으음..."));
        s1.Add(new StopSound());
        s1.Add(new Say("", "아... 힘들어"));
        s1.Add(new Say("", "나는 알람을 끄고도 자리에서 한동안 움직이지 않았다."));
        s1.Add(new Say("주인공", "...오늘은 뭐하지"));
        s1.Add(new Say("주인공", "어..."));
        s1.Add(new Say("주인공", "알바 구하기는 해야 되는데..."));
        
        return s1;
    }

    
}
