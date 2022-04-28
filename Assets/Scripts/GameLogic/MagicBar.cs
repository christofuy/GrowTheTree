using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxMagic()
    {
        slider.maxValue = GameParameters.MaxMagic;
        slider.value = 0;
    }

    public void SetMagic(int magic)
    {
        slider.value = magic;
    }

    public void GainMagic(int magic)
    {
        magic += 2;
        SetMagic(magic);
    }

    public void LoseMagic(int magic)
    {
        if (MagicMeterNotEmpty(magic))
        {
            magic -= 2;
            SetMagic(magic);
        }
    }

    public bool MagicMeterNotEmpty(int currentMagic)
    {
        if (currentMagic <= 0)
        {
            return false;
        }
        return true;
    }
}
