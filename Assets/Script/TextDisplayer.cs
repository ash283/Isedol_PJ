using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    IEnumerator showDialogueTextCoroutine;

    public void setText(string speaker, string content)
    {
        nameText.text = speaker;
        if (showDialogueTextCoroutine != null)
        {
            StopCoroutine(showDialogueTextCoroutine);
        }
        showDialogueTextCoroutine = showDialogueText(content);
        StartCoroutine(showDialogueTextCoroutine);
    }

    IEnumerator showDialogueText(string text, float secondPerChar = 0.02F)
    {
        int textIndex = 1;

        while (textIndex <= text.Length)
        {
            dialogueText.text = text.Substring(0, textIndex++);
            yield return new WaitForSeconds(secondPerChar);
        }
    }
}
