using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -20.9f;
    private float spawnLimitXRight = 8.2f;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    //void Update()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, SpawnRandomInterval());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // See the random interval
        //Debug.Log(SpawnRandomInterval());
    }

    int SpawnRandomInterval()
    {
        return Random.Range(3, 6);
    }
}
