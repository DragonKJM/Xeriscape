using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Image healthBar;
    public ScoreController scoreController;
    public float baseHealth;
    public float health;

    void Start()
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
            //Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("Player Score", scoreController.score);
        }

    }
}
