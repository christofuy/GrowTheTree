using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TermitePlacer : MonoBehaviour
{

    public GameObject TermitePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Place(5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 RandomPosition()
    {
        float min = 0.0f;
        float max = 1f;

        Vector3 final = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(min, max), 1, 10));
        return final;
    }


    public void Place(int limit)
    {

        int i = 0;
        while (i < limit)
        {
            Instantiate(TermitePrefab, RandomPosition(), Quaternion.identity);
            i++;
        }
        
    }
}
