using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{

    public Text counter;
    public GameObject[] enemies;

    

    public int count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        count = enemies.Length;
        counter.text = "Enemies On Screen: " + count;


    }



    
}
