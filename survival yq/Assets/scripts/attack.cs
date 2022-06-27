using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject sword;
    public float period = 2f;
    private float nextactiontime = 0;
    private bool can;

    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            sword.SetActive(true);
            
        }
        if (Time.time > nextactiontime)
        {
            Debug.Log("2");
            if (can == true)
            {
                can = false;
                sword.SetActive(false);
                nextactiontime += period;
                Debug.Log("2,1");
            }
            else
            {
                can = true;
                nextactiontime += period;
                Debug.Log("2,2");
                sword.SetActive(false);
            }
        }


    }
}
