using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollFruit : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    //Rolls fruit in direction towards middle of screen, at random speed
    {
        rb = GetComponent<Rigidbody2D>();

        if (transform.position.x > 0)
        {
            rb.AddForce(new Vector2(Random.Range(-15, -5), 0));
        }

        else if (transform.position.x < 0)
        {
            rb.AddForce(new Vector2(Random.Range(5, 15), 0));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
