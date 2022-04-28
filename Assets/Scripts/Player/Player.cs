using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxMagic = 100;
    public int currentMagic;
    public MagicBar magicbar;

    void Start()
    {
        currentMagic = maxMagic;
        magicbar.SetMaxMagic(maxMagic);
    }

    public bool MagicMeterNotEmpty(int currentMagic)
    {
        if (currentMagic <= 0) {
            return false;
        }
        return true;
    }
}
