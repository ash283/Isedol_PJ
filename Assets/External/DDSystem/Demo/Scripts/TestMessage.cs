using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TestMessage : MonoBehaviour
{
    public DialogManager DialogManager;
    public bool start;
    public int chapter;

    public GameObject cafebackground;

    public GameObject phone;

    void Start()
    {
     
        gameload();
    }


    public void gameload()
    {
        Debug.Log("로드");
        chapter = PlayerPrefs.GetInt("chapter");




        if (chapter > 1 && chapter < 3)
        {
            chapter2();

        }

        else if (chapter > -1 && chapter < 2)
        {
            Chapter1();

        }

        else if (chapter > 2 && chapter < 4)
        {
            chapter3();
            cafebackground.SetActive(true);

        }





    }

    private void Chapter1()
    {





        Debug.Log("챕터 1");
        chapter = 1;

        var dialogTexts = new List<DialogData>();


        dialogTexts.Add(new DialogData("아… 으음…", "Sa"));
        dialogTexts.Add(new DialogData("아… 힘들어.", "Sa"));
        dialogTexts.Add(new DialogData("나는 알람을 끄고도 자리에서 한동안 움직이지 않았다..", "Sa"));
        dialogTexts.Add(new DialogData("…오늘은 뭐하지", "Sa"));
        dialogTexts.Add(new DialogData("어….", "Sa"));
        dialogTexts.Add(new DialogData("알바 구하기는 해야 되는데.", "Sa"));
        dialogTexts.Add(new DialogData("아, 왁굳형 유튜브나 봐야겠다.", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/며칠전에 일하던 알바도 그만두고 백수가 되었다.", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/일자리를 구해야하기는 하지만 왠지 다시 알바를 할 의욕이 나지 않았다.", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/유튜브 알고리즘엔 왜 이렇게 자기발전, 동기부여 영상이 뜨는 거야, 내 인생 감시하나?", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/나도 고등학생때 까지는 나의 꿈도 분명했고, 이를 위해 노력도 열심히 했다.", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/하지만 언제부턴가 나는 목표와 꿈을 잃은 채 힘없고 의욕없는 삶을 살고 있었다.", "Sa"));
        dialogTexts.Add(new DialogData("…어디서부터 잘못된거지..", "Sa"));

        var dialogData = new DialogData("몰라. 그냥 오늘은 하루 종일 게임만 하다 자야지.", "Sa");



        dialogData.Callback = () => chapter2();


        dialogTexts.Add(dialogData);


        DialogManager.Show(dialogTexts);
    }



    void chapter2()
    {

        Debug.Log("챕터 2");
        chapter = 2;

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("으아… 힘들다", "Sa"));
        dialogTexts.Add(new DialogData("오늘도 그냥 놀까?", "Sa"));
        dialogTexts.Add(new DialogData("엄… 일단 아침부터 먹자.", "Sa"));
        dialogTexts.Add(new DialogData("음? 뭐야, 나 돈이 이렇게 없었나?", "Sa"));
        dialogTexts.Add(new DialogData("음… 일주일이면 다 바닥나겠네…", "Sa"));
        dialogTexts.Add(new DialogData("어떡하지?", "Sa"));

        dialogTexts.Add(new DialogData("여보세요? 잘 지내냐?", "Sa"));
        dialogTexts.Add(new DialogData("어 삼촌! 무슨 일로 전화하셨어요?", "Sa"));
        dialogTexts.Add(new DialogData("아 그냥~ 너 어떻게 지내는지 궁금해서 그랬지 ㅎㅎ", "Sa"));
        dialogTexts.Add(new DialogData("너 요즘도 알바 다니니?", "Sa"));
        dialogTexts.Add(new DialogData("아.. 며칠전에 관뒀어요", "Sa"));
        dialogTexts.Add(new DialogData("어 그래?? 잘 됐다", "Sa"));
        dialogTexts.Add(new DialogData("새 알바 구해줄까?", "Sa"));
        dialogTexts.Add(new DialogData("네??? 알바자리가 있어요?", "Sa"));
        dialogTexts.Add(new DialogData("나랑 친한 친구 딸이 카페를 하는데 거기서 알바생 구하고 있더라고 ㅎ", "Sa"));
        dialogTexts.Add(new DialogData("내가 연락해줄까??", "Sa"));
        dialogTexts.Add(new DialogData("어....", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/돈이 없어서 알바를 구해야하는데..", "Sa"));
        dialogTexts.Add(new DialogData("삼촌 그러면 연락해주실수 있으세요?", "Sa"));
        dialogTexts.Add(new DialogData("알았어. 그럼 내가 연락해 줄게", "Sa"));
        dialogTexts.Add(new DialogData("카페 아마 너네집 근처니깐 내가 어딘지 바로 보내줄게", "Sa"));
        dialogTexts.Add(new DialogData("너 전에 카페알바 몇 번 해봤으니깐 합격할 거야! 수고해~!", "Sa"));
        dialogTexts.Add(new DialogData("네, 감사합니다 삼촌", "Sa"));
        dialogTexts.Add(new DialogData("음... 어쩌다보니 알바자리가 구해졌다,", "Sa"));
        dialogTexts.Add(new DialogData("/color:grey/그리고 나는 무의식적으로 거울을 봤다", "Sa"));
        dialogTexts.Add(new DialogData("그래도 면접인데.. 조금 꾸미고 가야겠지??", "Sa"));
        dialogTexts.Add(new DialogData("/color:yellow/다음날", "Sa"));
        dialogTexts.Add(new DialogData("어디보자.. 여기서 앞으로 몇블록 더 가면 있다고??", "Sa"));

        var dialogData2 = new DialogData("아! 저기다!", "Sa");

        dialogData2.Callback = () => chapter3();

        dialogTexts.Add(dialogData2);


        DialogManager.Show(dialogTexts);
    }



    void chapter3()
    {

        Debug.Log("챕터 3");
        chapter = 3;
        cafebackground.SetActive(true);

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/color:grey/카페감람??", "Sa"));
        dialogTexts.Add(new DialogData("위치는 나름 좋은것 같네.", "Sa"));
        dialogTexts.Add(new DialogData("일단 목좀풀고.", "Sa"));
        dialogTexts.Add(new DialogData("큼..큼!", "Sa"));
        dialogTexts.Add(new DialogData("아 됐다, 알바를 많이 해봐도 면접 볼땐 계속 떨리네...", "Sa"));
        dialogTexts.Add(new DialogData("하이네! 어서오세요!", "Ine"));
        dialogTexts.Add(new DialogData("이른 아침부터 오셨네요?", "Ine"));
        dialogTexts.Add(new DialogData("지금 바로 주문하시겠어요?", "Ine"));
        dialogTexts.Add(new DialogData("/color:grey/응? 나를 손님으로 아는 거 같은데?", "Ine"));
        var dialogData3 = new DialogData("오케이 일단 들어가자", "Sa");

        

        dialogTexts.Add(dialogData3);

        DialogManager.Show(dialogTexts);
    }















}





