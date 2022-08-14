using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public GameObject treetype1;
    public GameObject treetype2;
    public GameObject nothing;
    public List<GameObject> items;
    // Start is called before the first frame update
    void Start()
    {
        items.Add(nothing);
        items.Add(nothing);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigcol");
        if (col.gameObject.tag == "tree1")
        {
            Debug.Log("tree1");
            items.Insert(0,treetype1);
            Destroy(col.gameObject);
            Debug.Log(items[0] + "and " + items[1]);
        } else if(col.gameObject.tag == "tree2")
        {
            Debug.Log("tree2");
            items.Insert(1, treetype2);
            Destroy(col.gameObject);
            Debug.Log(items[0] + "and " + items[1]);
        }
    }
}
