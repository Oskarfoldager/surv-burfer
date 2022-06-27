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
        if (Time.time > nextactiontime)
        {
            if(can == true)
            {
                can = false;
                sword.SetActive(false);
            }
            else
            {
                can = true;
            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            sword.SetActive(true);
        }

    }
}
