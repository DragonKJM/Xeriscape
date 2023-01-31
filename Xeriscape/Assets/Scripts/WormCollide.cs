using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormCollide : MonoBehaviour
{
    public ScoreController scoreController;
    public HealthController healthController;
    public AudioSource squash;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            {
                Destroy(gameObject);
                squash.Play();

                scoreController.score += 60;
                scoreController.UpdateScore();

                healthController.health += 60;
                healthController.UpdateHealthBar();


            }

        }
    }
}
