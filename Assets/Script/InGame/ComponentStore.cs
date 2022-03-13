using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComponentStore
{
    private static TextDisplayer _textDisplayer;
    private static SoundManager _soundManager;

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

    public static SoundManager soundManager
    {
        get
        {
            if (!_soundManager)
            {
                _soundManager = Object.FindObjectOfType<SoundManager>();
            }
            return _soundManager;
        }
    }
}
