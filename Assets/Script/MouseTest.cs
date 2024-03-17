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
            Quaternion startRotation = transform.rotation; // 获取起始姿态的四元数表示方式
            Quaternion endRotation = transform.rotation * Quaternion.Euler(0, 90, 0); // 计算终止姿态的四元数表示方式
            Quaternion currentRotation = Quaternion.Lerp(startRotation, endRotation,Time.deltaTime); // 插值得到当前的四元数
            transform.rotation = currentRotation; // 将当前的四元数转换为旋转并应用于物体的坐标系
        }
     //  print(mouse.position.ReadValue());
      // print(mouse.delta.ReadValue());//上一针和当前帧的偏移值
       print(mouse.scroll.ReadValue());
    }
}
