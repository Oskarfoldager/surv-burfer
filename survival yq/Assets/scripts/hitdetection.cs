using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitdetection : MonoBehaviour
{
    public static int healthpoints = 10;
    public GameObject enemy;
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            Destroy(enemy);
            healthpoints--;
            Debug.Log(healthpoints);
        }
    }
}
