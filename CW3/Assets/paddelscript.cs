using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddelscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        move();
    }



    void move()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }
}
