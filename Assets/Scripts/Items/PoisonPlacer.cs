using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonPlacer : TimedObjectPlacer
{
    void Start()
    {
        minimumTimeToCreation = GameParameters.PoisonMinimumTimeToNextCreation;
        maximumTimeToCreation = GameParameters.PoisonMaximumTimeToNextCreation;
    }
}
