using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealthBar : MonoBehaviour
{
    public Slider slider;

    private int totalTreeHealth = 100;

    public void Start()
    {
        SetMaxTreeHealth(GameParameters.TreeLvl1MaxHealth);
    }

    public void SetMaxTreeHealth(int amount)
    {
        slider.maxValue = amount;
        ShowTreeHealth();
    }

    public void ShowTreeHealth()
    {
        slider.value = totalTreeHealth;
    }

    public void GainTreeHealth()
    {
        if (!TreeHealthMeterFull())
        {
            totalTreeHealth += GameParameters.PetalHealth;
            print("+ Tree Health = " + totalTreeHealth);
            ShowTreeHealth();
        }
    }

    public void LoseTreeHealth()
    {
        if (TreeHealthMeterNotEmpty())
        {
            totalTreeHealth -= GameParameters.TermiteAttackDamage;
            print("Lost health! Current TREE health:" + totalTreeHealth);
            ShowTreeHealth();
        }
    }

    public bool TreeHealthMeterNotEmpty()
    {
        if (totalTreeHealth <= 0)
        {
            return false;
        }
        return true;
    }

    public bool TreeHealthMeterFull()
    {
        if (totalTreeHealth >= 100)
        {
            return true;
        }
        return false;
    }
}
