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
        print(ts.touches.Count);//�ж���ָ������
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
        //�������
        if (tc.tap.isPressed)
        {

        }
        print(tc.tapCount);
        //λ��
        print(tc.position.ReadValue());
        //��һ�νӴ�λ��
        print(tc.startPosition.ReadValue());
        //�Ӵ������С
        tc.radius.ReadValue();
        //ƫ��λ��
        tc.delta.ReadValue();
        //�õ���ǰ��ָ��״̬
         UnityEngine.InputSystem.TouchPhase touchPhase = tc.phase.ReadValue();
    }
}
