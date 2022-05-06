using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider slider;

    private int totalPlayerHealth = 100;

    public void Start()
    {
        SetMaxPlayerHealth();
    }

    public void SetMaxPlayerHealth()
    {
        slider.maxValue = GameParameters.PlayerMaxHealth;
        ShowPlayerHealth();
    }

    public void ShowPlayerHealth()
    {
        slider.value = totalPlayerHealth;
    }

    public void GainPlayerHealth()
    {
        totalPlayerHealth += 10;
        print("+ Player Health = " + totalPlayerHealth);
        ShowPlayerHealth();
    }

    public void LosePlayerHealth()
    {
        if (PlayerHealthMeterNotEmpty())
        {
            totalPlayerHealth -= GameParameters.TermiteAttackDamage;
            print("Lost health! Current health:" + totalPlayerHealth);
            ShowPlayerHealth();
        }
    }

    public bool PlayerHealthMeterNotEmpty()
    {
        if (totalPlayerHealth <= 0)
        {
            return false;
        }
        return true;
    }
}

