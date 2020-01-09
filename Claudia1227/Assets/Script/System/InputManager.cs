using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputKey
{
    LEFT    = 0,
    RIGHT   ,
    JMUP    ,
    DOWN    ,
    ACTION  ,
    CALL    ,
    CRAWL   ,
    KEYCOUNT
}

public static class KeySetting { public static Dictionary<InputKey, KeyCode> keys = new Dictionary<InputKey, KeyCode>(); }

public class InputManager : MonoBehaviour
{
    KeyCode[] resetKeys = new KeyCode[] { KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S, KeyCode.E, KeyCode.R, KeyCode.LeftControl };
    public KeyCode[] ResetKeys { get => resetKeys; set => resetKeys = value; }

    void Awake()
    {
        ResetKey();
    }
    
    void ResetKey()
    {
        for(int i =0;i<(int)InputKey.KEYCOUNT;i++)
        {
            KeySetting.keys.Add((InputKey)i, ResetKeys[i]);
        }
    }

}
