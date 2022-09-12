using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
   
    AudioSource aoudio;
    Rigidbody2D rb;
    public float maxSpeed;
    void Start()
    {
        aoudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixeedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        aoudio.Play();
    }
}
