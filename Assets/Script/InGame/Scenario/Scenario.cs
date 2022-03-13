using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Scenario
{
    public static List<Command> getS1()
    {
        List<Command> s1 = new List<Command>();
        s1.Add(new PlaySound(SoundManager.AUDIO.FX_ALARM));
        s1.Add(new Say("���ΰ�", "��... ����..."));
        s1.Add(new StopSound());
        s1.Add(new Say("", "��... �����"));
        s1.Add(new Say("", "���� �˶��� ���� �ڸ����� �ѵ��� �������� �ʾҴ�."));
        s1.Add(new Say("���ΰ�", "...������ ������"));
        s1.Add(new Say("���ΰ�", "��..."));
        s1.Add(new Say("���ΰ�", "�˹� ���ϱ�� �ؾ� �Ǵµ�..."));
        
        return s1;
    }

    
}
