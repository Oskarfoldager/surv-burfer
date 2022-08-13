using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixshit : MonoBehaviour
{
    public static BoxCollider2D a;
    public BoxCollider2D b;
    // Start is called before the first frame update
    void Start()
    {
        a = b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
