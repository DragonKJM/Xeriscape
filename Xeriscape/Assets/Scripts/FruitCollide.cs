using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollide : MonoBehaviour
{
    public ScoreController scoreController;
    public PlayerMovement playerMovement;
    public HealthController healthController;
    public AudioSource squash;

    public float healthDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //For collisions, it needs to specify gameObject
        {
            //if boosting
            if (playerMovement.moveSpeed > playerMovement.moveSpeedBase)
            {
                Destroy(gameObject);
                squash.Play();
                scoreController.score += 15;
                scoreController.UpdateScore();
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Flower"))
        {
            healthController.health -= healthDamage;
            healthController.UpdateHealthBar();
        }
    }

    private void Update()
    {
        //Ignore all instances of enemies and self
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 1; i < Enemies.Length; i++)
        {
            Physics2D.IgnoreCollision(Enemies[i].GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

       if (gameObject.transform.position.y < -5 )
        {
            Destroy(gameObject);
        }
    }
}
