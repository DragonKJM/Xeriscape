using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Image healthBar;
    public ScoreController scoreController = GameObject.Find("/Background/Flower").GetComponent<ScoreController>(); //Figured out how to find and reference scripts here, like I was trying to do in fruitspawner

    public float baseHealth;
    public float health;

    private void Start()
    {
        health = baseHealth;
        healthBar.color = new Color32 (11,123,14, 255);
    }

    public void UpdateHealthBar()
    {
       healthBar.fillAmount = health / baseHealth;

        if (health > 100) 
            health = 100;

        if (health <= 30)
            healthBar.color = new Color32 (108,16,0,255);

        if (health <= 0)
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("Player Score", scoreController.score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
