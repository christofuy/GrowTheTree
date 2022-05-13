using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealthBar : MonoBehaviour
{
    public Slider slider;
    public GreatTree greatTree;

    public int currentTreeHealth;
    public int maximumTreeHealth;

    public GameProperties gameproperties;

    public void Start()
    {
        SetMaxTreeHealth(GameParameters.TreeLvl1MaxHealth);
        currentTreeHealth = maximumTreeHealth;
    }

    void Update()
    {
        if (currentTreeHealth <= 0)
        {
            gameproperties.GameOver();
        }
        else
        {
            UpdateTreeHealth();
        }
        
    }

    public void SetMaxTreeHealth(int amount)
    {
        slider.maxValue = amount;
        maximumTreeHealth = amount;
    }

    public void UpdateTreeHealth()
    {
        slider.value = currentTreeHealth;
    }

    public void FillToMax()
    {
        currentTreeHealth = maximumTreeHealth;
    }

    //GAINING + LOSING HEALTH
    //& the Checks and Balances Involved in Doing So
    public void GainTreeHealth()
    {
        if (!TreeHealthMeterFull())
        {
            currentTreeHealth += GameParameters.PetalHealth;
            print("+ Tree Health = " + currentTreeHealth);
            UpdateTreeHealth();
        }
    }

    public void LoseTreeHealth()
    {
        if (TreeHealthMeterNotEmpty())
        {
            currentTreeHealth -= GameParameters.TermiteAttackDamage;
            print("Lost health! Current TREE health:" + currentTreeHealth);
            UpdateTreeHealth();
        }
        else
            TreeDie();
    }

    public bool TreeHealthMeterNotEmpty()
    {
        if (currentTreeHealth <= 0)
        {
            return false;
        }
        return true;
    }

    public bool TreeHealthMeterFull()
    {
        if (currentTreeHealth >= 100)
        {
            return true;
        }
        return false;
    }

    public void TreeDie()
    {
        gameproperties.GameOver();
    }


}
