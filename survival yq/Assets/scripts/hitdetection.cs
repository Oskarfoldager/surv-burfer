using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitdetection : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("hit");
        }
    }
}
