using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPlacer : TimedObjectPlacer
{
    void Start()
    {
        minimumTimeToCreation = GameParameters.HeartMinimumTimeToNextCreation;
        maximumTimeToCreation = GameParameters.HeartMaximumTimeToNextCreation;
    }
}
