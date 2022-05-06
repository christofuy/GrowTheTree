using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameParameters
{
    //Fruit Parameters
    public static int FruitMinimumTimeToNextCreation = 3;
    public static int FruitMaximumTimeToNextCreation = 6;
    public static int FruitSecondsOnScreen = 3;

    //Magic Parameters
    public static int FruitGiveMagicPoints = 2;
    public static int CurrentMagic = 0;
    public static int MaxMagic = 100;
    public static int MagicDrainRate = 2;

    //Termite Parameters
    public static int TermiteMaxHealth = 40;
    public static int TermiteSpawnAmount = 5;
    public static int TermiteAttackDamage = 10;

    //Player Parameters
    public static int PlayerMaxHealth = 100;
    public static int PlayerMeleeDamage = 10;
    public static int PlayerProjectileDamage = 20;

    //Tree Parameters
    public static int TreeLvl1MaxHealth = 100;
    public static int TreeLvl2MaxHealth = 200;
    public static int TreeLvl3MaxHealth = 300;

}
