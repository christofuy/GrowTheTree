using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectPlacer : MonoBehaviour
{

    public GameObject Prefab;
    private int secondsUntilNextCreation;
    private bool isWaitingToCreate = false;

    protected int minimumTimeToCreation = 1;
    protected int maximumTimeToCreation = 2;

    private void Update()
    {
        if (!isWaitingToCreate)
        {
            secondsUntilNextCreation = Random.Range(minimumTimeToCreation, maximumTimeToCreation);
            isWaitingToCreate = true;
            StartCoroutine(CountdownUntilCreation());
        }

    }

    IEnumerator CountdownUntilCreation()
    {
        yield return new WaitForSeconds(secondsUntilNextCreation);
        Place();
        isWaitingToCreate = false;
    }

    protected virtual void Place()
    {
        Vector3 position = ScreenPositionTools.RandomWorldLocationNoCamera();
        Instantiate(Prefab, position, Quaternion.identity);
    }
}