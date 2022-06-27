using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordpivot : MonoBehaviour
{
    public Vector3 player;
    public Transform player3;
    public GameObject sword;
    public float armlength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = player3.position;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            sword.transform.position = new Vector3(player.x - (armlength),player.y,player.z);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            sword.transform.position = new Vector3(player.x + (armlength), player.y, player.z);


        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            sword.transform.position = new Vector3(player.x , player.y + (armlength), player.z);

        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            sword.transform.position = new Vector3(player.x , player.y - (armlength), player.z);


        }
    }
}
