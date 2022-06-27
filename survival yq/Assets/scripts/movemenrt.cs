using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemenrt : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            movedown();

        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {

            moveup();

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            moveleft();

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            moveright();

        }
    }

    public void moveup()
    {
        rb.MovePosition(new Vector3(rb.position.x, rb.position.y + (float)0.03));
    }

    public void movedown()
    {
        rb.MovePosition(new Vector3(rb.position.x, rb.position.y - (float)0.03));
    }
    public void moveright()
    {
        rb.MovePosition(new Vector3(rb.position.x + (float)0.03, rb.position.y));
        transform.eulerAngles = new Vector3(0f, 180f, 0f);
    }
    public void moveleft()
    {
        rb.MovePosition(new Vector3(rb.position.x - (float)0.03, rb.position.y));
        transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
