using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{

    public GameObject fruitToSpawn;
    private float spawnRate;
    public float spawnRateMax = 9;
    public float spawnRateMin = 5;
    bool rateLowered = true;

    private float time = 0;

    public ScoreController scoreController;
    public PlayerMovement playerMovement;
    public HealthController healthController;
    public AudioSource squash;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        time += Time.deltaTime;
        if (time > spawnRate)
        {
            GameObject fruit = Instantiate(fruitToSpawn, transform.position, transform.rotation); //instantiates the fruit object

            fruit.GetComponent<FruitCollide>().scoreController = scoreController; //Assigns scorecontroller script to instantiated object
            fruit.GetComponent<FruitCollide>().playerMovement = playerMovement;
            fruit.GetComponent<FruitCollide>().healthController = healthController;
            fruit.GetComponent<FruitCollide>().squash = squash;

            time = 0;
            rateLowered = false;
        }

        if (spawnRateMin > 1 && rateLowered == false)
        {
            if ((Time.time % 20) < 0.5) //every 10 seconds, with 0.5 seconds for error
            {
                spawnRateMin -= 1;
                spawnRateMax -= 1;
                rateLowered = true;
            }
        }
    }
}
