using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public static InputManager instance;
    IInput _input;

    public void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
//#if UNITY_EDITOR || UNITY_STANDALONE_WIN
        _input = new KeyboardInput();
//#elif UNITY_ANDROID
//#endif
    }

    public float GetHAxis()
    {
        return _input.GetHAxis();
    }
    public float GetVAxis()
    {
        return _input.GetVAxis();
    }
}
