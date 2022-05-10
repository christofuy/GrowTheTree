using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : TimedObject
{
    public override void Start()
    {
        secondsOnScreen = GameParameters.HeartSecondsOnScreen;
        base.Start();
    }
}
