using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : TimedObject
{
    public override void Start()
    {
        secondsOnScreen = GameParameters.FruitSecondsOnScreen;
        base.Start();
    }
}
