using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseTest : MonoBehaviour
{
    Mouse mouse;

    void Start()
    {
        mouse = Mouse.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
          
            

        }
        if (mouse.leftButton.wasReleasedThisFrame)
        {

        }
        if (mouse.leftButton.isPressed)
        {
            Quaternion startRotation = transform.rotation; // ��ȡ��ʼ��̬����Ԫ����ʾ��ʽ
            Quaternion endRotation = transform.rotation * Quaternion.Euler(0, 90, 0); // ������ֹ��̬����Ԫ����ʾ��ʽ
            Quaternion currentRotation = Quaternion.Lerp(startRotation, endRotation,Time.deltaTime); // ��ֵ�õ���ǰ����Ԫ��
            transform.rotation = currentRotation; // ����ǰ����Ԫ��ת��Ϊ��ת��Ӧ�������������ϵ
        }
     //  print(mouse.position.ReadValue());
      // print(mouse.delta.ReadValue());//��һ��͵�ǰ֡��ƫ��ֵ
       print(mouse.scroll.ReadValue());
    }
}
