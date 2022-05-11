using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameParameters
{
    //Fruit
    public static int FruitMinimumTimeToNextCreation = 3;
    public static int FruitMaximumTimeToNextCreation = 6;
    public static int FruitSecondsOnScreen = 3;

    //Poison
    public static int PoisonMinimumTimeToNextCreation = 3;
    public static int PoisonMaximumTimeToNextCreation = 6;
    public static int PoisonSecondsOnScreen = 3;
    //public static int PoisonDamage = 10;

    //Petal
    public static int PetalMinimumTimeToNextCreation = 8;
    public static int PetalMaximumTimeToNextCreation = 12;
    public static int PetalSecondsOnScreen = 3;
    public static int PetalHealth = 10;

    //Heart
    public static int HeartMinimumTimeToNextCreation = 4;
    public static int HeartMaximumTimeToNextCreation = 8;
    public static int HeartSecondsOnScreen = 3;
    public static int HeartHealth = 10;

    //Magic 
    public static int FruitGiveMagicPoints = 2;
    public static int CurrentMagic = 0;
    public static int MaxMagic = 100;
    public static int MagicDrainRate = 2;

    //Termite
    public static int TermiteMaxHealth = 40;
    public static int TermiteAttackDamage = 10;

        public static int TermiteSpawnAmount_W1 = 4;
        public static int TermiteSpawnAmount_W2 = 8;
        public static int TermiteSpawnAmount_W3 = 12;

    //Player
    public static int PlayerMaxHealth = 100;
    public static int PlayerMeleeDamage = 10;
    public static int PlayerProjectileDamage = 20;

    //Tree
    public static int TreeLvl1MaxHealth = 100;
    public static int TreeLvl2MaxHealth = 200;
    public static int TreeLvl3MaxHealth = 300;

}
