using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SphereBehevior : MonoBehaviour
{
    public InputAction Move;
    public InputAction Jump;
    public InputAction Fire;
    private Rigidbody rb;
    public GameObject Bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Move.Enable();   
        Jump.Enable();
        Fire.Enable();
        Jump.performed += (context) =>
        {
            rb.AddForce(Vector3.up * 200);
        };
        Fire.performed += (context) =>
        {
            RaycastHit raycastHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out raycastHit))
            {
                Vector3 point = raycastHit.point;
                point.y = this.transform.position.y;
                Vector3 dir = point - this.transform.position;
                Instantiate(Bullet,this.transform.position, Quaternion.LookRotation(dir));
            }
        };
    }

    void Update()
    {
        Vector3 dir = Move.ReadValue<Vector2>();
        dir.z = dir.y;
        dir.y = 0;
        rb.AddForce(dir * 2);
    
    }
}
