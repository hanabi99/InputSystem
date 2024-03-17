using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Lesson11EX : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 dir;
    public Rigidbody rb;
    public bool isFire;
    public PlayerInput playerInput;

    public void Start()
    {
        playerInput.onActionTriggered += (context) =>
        {
            switch (context.action.name)
            {
                case "Move":
                    if (context.phase == InputActionPhase.Performed)
                    {
                        dir = context.ReadValue<Vector2>();
                        dir.z = dir.y;
                        dir.y = 0;
                    }
                    break;
                case "Jump":
                    if (context.phase == InputActionPhase.Performed)
                    {
                        rb.AddForce(Vector3.up * 200);
                    }
                        break;
                case "Fire":
                    if (context.started)
                    {
                        isFire = true;
                    }
                    else if (context.canceled)
                    {
                        isFire = false;
                    }
                    break;
            }

        };
    }

   

    private void Update()
    {
        rb.AddForce(dir * 2);
        if (isFire)
        {
            Fire();
        }
    }
    public void OnJump(InputValue inputValue)
    {
        rb.AddForce(Vector3.up * 200);
    }
    public void OnFire(InputValue inputValue)
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out raycastHit))
        {
            Vector3 point = raycastHit.point;
            point.y = this.transform.position.y;
            Vector3 dir = point - this.transform.position;
            Instantiate(bullet, this.transform.position, Quaternion.LookRotation(dir));
        }
    }
    public void OnMove(InputValue inputValue)
    {
        dir = inputValue.Get<Vector2>();
        dir.z = dir.y;
        dir.y = 0;
    }



    public void OnJump(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up * 200);
    }
    public void OnFire(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isFire = true;
        }
        else if (context.canceled)
        {
            isFire = false;
        }
    }
    public void Fire()
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out raycastHit))
        {
            Vector3 point = raycastHit.point;
            point.y = this.transform.position.y;
            Vector3 dir = point - this.transform.position;
            Instantiate(bullet, this.transform.position, Quaternion.LookRotation(dir));
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        dir = context.ReadValue<Vector2>();
        dir.z = dir.y;
        dir.y = 0;
    }
}
