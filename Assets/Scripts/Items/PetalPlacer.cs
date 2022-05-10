using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalPlacer : TimedObjectPlacer
{
    void Start()
    {
        minimumTimeToCreation = GameParameters.PetalMinimumTimeToNextCreation;
        maximumTimeToCreation = GameParameters.PetalMaximumTimeToNextCreation;
    }
}
