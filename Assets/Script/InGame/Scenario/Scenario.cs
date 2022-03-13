using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Scenario
{
    private static string protagonist= "주인공";

    public static List<Command> getS1()
    {
        List<Command> s1 = new List<Command>();
        s1.Add(new PlaySound(SoundManager.AUDIO.FX_ALARM));
        s1.Add(new Say(protagonist, "아... 으음..."));
        s1.Add(new StopSound());
        s1.Add(new Say("", "아... 힘들어"));
        s1.Add(new Say("", "나는 알람을 끄고도 자리에서 한동안 움직이지 않았다."));
        s1.Add(new Say(protagonist, "...오늘은 뭐하지"));
        s1.Add(new Say(protagonist, "어..."));
        s1.Add(new Say(protagonist, "알바 구하기는 해야 되는데..."));
        s1.Add(new Say(protagonist, "아, 왁굳형 유투브나 봐야겠다."));
        s1.Add(new Say("", "내 이름은"));
        s1.Add(new Say("", "며칠전에 일하던 알바도 그만두고 백수가 되었다."));
        s1.Add(new Say("", "일자리를 구해야하기는 하지만 왠지 다시 알바를 할 의욕이 나지 않았다."));
        s1.Add(new Say(protagonist, "유튜브 알고리즘엔 왜 이렇게 자기발전, 동기부여 영상이 뜨는 거야, 내 인생 감시하나?"));
        s1.Add(new Say(protagonist, "나도 고등학생때 까지는 나의 꿈도 분명했고, 이를 위해 노력도 열심히 했다."));
        s1.Add(new Say(protagonist, "하지만 언제부턴가 나는 목표와 꿈을 잃은 채 힘없고 의욕없는 삶을 살고 있었다."));
        s1.Add(new Say(protagonist, "…어디서부터 잘못된거지?"));

        return s1;
    }


    
}
