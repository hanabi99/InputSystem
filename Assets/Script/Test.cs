using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    Keyboard keyboard = Keyboard.current;
    private void Update()
    {
       
        //是否被按下    
        if (keyboard.spaceKey.wasPressedThisFrame)
        {
            print("Space");
        }
        if (keyboard.bKey.wasReleasedThisFrame)
        {
            print("b");
        }
        if (keyboard.cKey.isPressed)
        {
            print("长按");
        }
        if (keyboard.anyKey.isPressed)
        {
            print("anykey");
        }
    }
    public void Fire(InputAction.CallbackContext callbackContext)
    {
        Debug.Log("?");
    }

    private void Start()
    {
        //获得输入的值
        keyboard.onTextInput += (key) =>
        {
            print("lanbda" + key);
        };
        keyboard.onTextInput += OnText;

    }
    public void OnText(char c)
    {
        print("func" + c);
    }
    public void OnDestroy()
    {
        keyboard.onTextInput -= OnText;
    }
}
