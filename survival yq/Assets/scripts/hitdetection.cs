using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitdetection : MonoBehaviour
{
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            Destroy(enemy);
        }
    }
}
