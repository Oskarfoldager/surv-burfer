using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hitdetection : MonoBehaviour
{
    public static int healthpoints = 10;
    public GameObject enemy;
    public static int points;
    public int enemystrength;
    public int enemysvalue;
    public float period = 200f;
    private float nextactiontime = 0;
    private bool isconnecting = false;
    public BoxCollider2D thisenemy;
    public BoxCollider2D thisenemy2;
    private BoxCollider2D player;
    public static int heathl;


    void OnTriggerEnter2D(Collider2D col1)
    {
        Debug.Log("OnCollisionEnter2D");

        if (col1.gameObject.tag == "sword")
        {
            Debug.Log("hit");
            Destroy(enemy);
            points+= enemysvalue;

        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isconnecting = true;


        } 
    }


    public void Update()
    {
        Debug.Log("time is " + nextactiontime);
        heathl = enemystrength;
        Debug.Log(isconnecting);
        if (thisenemy.IsTouching(player) == false || thisenemy2.IsTouching(player) == false )
        {
            isconnecting = false;
        }
        if (isconnecting == true)
        {
            if (Time.time > nextactiontime)
            {
                Debug.Log("hitie");
                //Destroy(enemy);
                healthpoints -= enemystrength;
                GameObject.FindObjectOfType<healthbar>().kill();
                Debug.Log("heeelat is"+healthpoints);
                nextactiontime += period;
            }
        }
    }
    public void Start()
    {
        player = fixshit.a;
    }




}
