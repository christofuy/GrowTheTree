using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitPlacer : TimedObjectPlacer
{
    void Start()
    {
        minimumTimeToCreation = GameParameters.FruitMinimumTimeToNextCreation;
        maximumTimeToCreation = GameParameters.FruitMaximumTimeToNextCreation;
    }
}
