using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Scenario
{
    private static string protagonist= "���ΰ�";

    public static List<Command> getS1()
    {
        List<Command> s1 = new List<Command>();
        s1.Add(new PlaySound(SoundManager.AUDIO.FX_ALARM));
        s1.Add(new Say(protagonist, "��... ����..."));
        s1.Add(new StopSound());
        s1.Add(new Say("", "��... �����"));
        s1.Add(new Say("", "���� �˶��� ���� �ڸ����� �ѵ��� �������� �ʾҴ�."));
        s1.Add(new Say(protagonist, "...������ ������"));
        s1.Add(new Say(protagonist, "��..."));
        s1.Add(new Say(protagonist, "�˹� ���ϱ�� �ؾ� �Ǵµ�..."));
        s1.Add(new Say(protagonist, "��, �α��� �����곪 ���߰ڴ�."));
        s1.Add(new Say("", "�� �̸���"));
        s1.Add(new Say("", "��ĥ���� ���ϴ� �˹ٵ� �׸��ΰ� ����� �Ǿ���."));
        s1.Add(new Say("", "���ڸ��� ���ؾ��ϱ�� ������ ���� �ٽ� �˹ٸ� �� �ǿ��� ���� �ʾҴ�."));
        s1.Add(new Say(protagonist, "��Ʃ�� �˰��� �� �̷��� �ڱ����, ����ο� ������ �ߴ� �ž�, �� �λ� �����ϳ�?"));
        s1.Add(new Say(protagonist, "���� ����л��� ������ ���� �޵� �и��߰�, �̸� ���� ��µ� ������ �ߴ�."));
        s1.Add(new Say(protagonist, "������ �������ϰ� ���� ��ǥ�� ���� ���� ä ������ �ǿ���� ���� ��� �־���."));
        s1.Add(new Say(protagonist, "����𼭺��� �߸��Ȱ���?"));

        return s1;
    }


    
}
