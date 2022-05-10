using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public TermitePlacer TermitePlacer;
    public EnemyCounter EnemyCounter;
    public GreatTree GreatTree;

    public bool AfterInitialSpawn = false;

    public bool isCurrentWaveActive = false;
    public bool isCurrentWaveZeroed = false;

    public int currentWaveNumber = 0;

    public int EnemiesOnScreen()
    {
        return EnemyCounter.count;
    }

    // Start is called before the first frame update
    void Start()
    {
        Wave(currentWaveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesOnScreen() == 0 & Time.frameCount>1)
        {
            if (isCurrentWaveActive == true)
            {
                ZeroWave();
                currentWaveNumber++;
                print("CurrentWave Number = " + currentWaveNumber);
            }
            else if (isCurrentWaveActive == false)
            {
                Wave(currentWaveNumber);
            }
        }
    }



    public void ZeroWave()
    {

        if(isCurrentWaveActive)
        {
            isCurrentWaveActive = false;
            isCurrentWaveZeroed = true;
            GreatTree.TreeLevelUp();
        }
    }



    public void Wave(int num)
    {
        if (num==0)
        {
            currentWaveNumber = 1;
        }
        if (num==1)
        {
            TermitePlacer.Place(GameParameters.TermiteSpawnAmount_W1);
            isCurrentWaveActive = true;
        }
        if (num == 2)
        {
            TermitePlacer.Place(GameParameters.TermiteSpawnAmount_W2);
            isCurrentWaveActive = true;
        }

    }
   
}
