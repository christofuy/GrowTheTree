using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : TimedObject
{
    public override void Start()
    {
        secondsOnScreen = GameParameters.PoisonSecondsOnScreen;
        base.Start();
    }
}
