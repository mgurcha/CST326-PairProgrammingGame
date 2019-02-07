using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceDoor : MonoBehaviour
{
    public float forceAmount = 1000f;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonUp("Fire3"))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * forceAmount, ForceMode.Acceleration);
            GetComponent<Rigidbody>().useGravity = true;
        }
            
    }
}
