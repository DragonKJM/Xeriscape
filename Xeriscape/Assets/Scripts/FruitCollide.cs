using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollide : MonoBehaviour
{
    public ScoreController scoreController;
    public PlayerMovement PlayerMovement;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //For collisions, it needs to specify gameObject
        {
            //if boosting
            if (PlayerMovement.moveSpeed > PlayerMovement.moveSpeedBase)
            {
                Destroy(gameObject);
                scoreController.score += 15;
                scoreController.UpdateScore();
            }
            
        }
    }
}
