using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TermitePlacer : MonoBehaviour
{

    public GameObject TermitePrefab;
    public Camera viewcamera;


    // Start is called before the first frame update
    void Start()
    {
        //Place(GameParameters.TermiteSpawnAmount);
        //We are letting the Waves class handle spawning for each wave
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 RandomSpawnDirection()
    {
        int spawnDirection = Random.Range(0, 4);
        string finalDirection = "";

        if (spawnDirection == 0)
        {
            finalDirection = "top";
        }
        else if (spawnDirection == 1)
        {
            finalDirection = "right";
        }
        else if (spawnDirection == 2)
        {
            finalDirection = "bottom";
        }
        else if (spawnDirection == 3)
        {
            finalDirection = "left";
        }
        else
        {
            print("There was an error in generating a randomized spawn direction");
        }
        Vector3 spawn = ScreenPositionTools.RandomEdgeOfScreenWorldLocation(viewcamera, finalDirection);
        return spawn;
    }


    public void Place(int limit)
    {

        int i = 0;
        while (i < limit)
        {
            Instantiate(TermitePrefab, RandomSpawnDirection(), Quaternion.identity);
            i++;
        }
        
    }
}
