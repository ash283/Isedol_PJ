using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComponentStore
{
    private static TextDisplayer _textDisplayer;

    public static TextDisplayer textDisplayer 
    {
        get
        {
            if (!_textDisplayer)
            {
                _textDisplayer = Object.FindObjectOfType<TextDisplayer>();
            }
                return _textDisplayer;
        }
    }
}
