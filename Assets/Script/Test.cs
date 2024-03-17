using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    Keyboard keyboard = Keyboard.current;
    private void Update()
    {
       
        //�Ƿ񱻰���    
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
            print("����");
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
        //��������ֵ
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
