using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueCube : MonoBehaviour
{
    public float amount = 50f;


    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Jump") * amount * Time.deltaTime;
        float v = Input.GetAxis("Jump") * amount * Time.deltaTime;


        rb.AddTorque(transform.up * h, ForceMode.Impulse);
        rb.AddTorque(transform.right * v, ForceMode.Impulse);
    }

}
