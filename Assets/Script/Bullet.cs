using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 3);
    }

    private void Update()
    {
        this.transform.Translate(Vector3.forward * 30 * Time.deltaTime);
    }
}
