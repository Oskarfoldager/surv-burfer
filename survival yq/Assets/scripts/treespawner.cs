using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawner : MonoBehaviour
{
    public GameObject tree2;
    public GameObject tree1;

    public int treenumber;


    void Start()
    {

        List<GameObject> trees = new List<GameObject>() { tree1,tree2  };
        for (int i = 0; i < treenumber; i++)
        {
            Debug.Log("Creating new trashcan " + i);
            var position = new Vector3(Random.Range(-17.5f, 83.5f), Random.Range(-55f, 25.52f), 0f);
            Instantiate(trees[Random.Range(0,2)], position, Quaternion.identity);
        }



    }
}
