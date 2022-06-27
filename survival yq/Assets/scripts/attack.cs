using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.E))
            {
                sword.SetActive(true);





        }

    }
}
