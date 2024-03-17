using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class L16_JSON : MonoBehaviour
{
    public PlayerInput playerInput;
    void Start()
    {
        string json = Resources.Load<TextAsset>("PlayerInputTest").text;
        InputActionAsset asset = InputActionAsset.FromJson(json);
        playerInput.actions = asset;

        playerInput.onActionTriggered += (context) =>
        {
            switch (context.action.name)
            {
                case "Fire":
                    print("??");
                    break;
            }
        };
    }

   
    void Update()
    {
        
    }
}
