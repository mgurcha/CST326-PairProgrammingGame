using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tidy : MonoBehaviour
{
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Brick")
        {
            Destroy(col.gameObject);
        }
    }

}
