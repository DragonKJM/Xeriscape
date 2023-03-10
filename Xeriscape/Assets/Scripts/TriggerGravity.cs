using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGravity : MonoBehaviour
{
    private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If player touches sky, turn on gravity
        if (collision.CompareTag("Player"))
        {
            rb = collision.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition; // if you don't refreeze X it often glitches and moves the player sideways
        }
    }

}
