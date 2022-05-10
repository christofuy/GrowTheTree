using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petal : TimedObject
{
    public override void Start()
    {
        secondsOnScreen = GameParameters.PetalSecondsOnScreen;
        base.Start();
    }
}
