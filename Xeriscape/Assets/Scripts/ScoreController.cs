using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void UpdateScore()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score: " + score;
    }
}
