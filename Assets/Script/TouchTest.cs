using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class TouchTest : MonoBehaviour
{
    private void Start()
    {
        Touchscreen ts = Touchscreen.current;

        if(ts == null)
        {
            return;
        }
        print(ts.touches.Count);//判断手指的数量
        TouchControl tc =  ts.touches[0];
        //foreach get all finger
        foreach (TouchControl item in ts.touches)
        {

        }
        if (tc.press.wasPressedThisFrame)
        {

        }
        if (tc.press.wasReleasedThisFrame)
        {

        }
        if (tc.press.isPressed)
        {

        }
        //点击手势
        if (tc.tap.isPressed)
        {

        }
        print(tc.tapCount);
        //位置
        print(tc.position.ReadValue());
        //第一次接触位置
        print(tc.startPosition.ReadValue());
        //接触区域大小
        tc.radius.ReadValue();
        //偏移位置
        tc.delta.ReadValue();
        //得到当前手指的状态
         UnityEngine.InputSystem.TouchPhase touchPhase = tc.phase.ReadValue();
    }
}
