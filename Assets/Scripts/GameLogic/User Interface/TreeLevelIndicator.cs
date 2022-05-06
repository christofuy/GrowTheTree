using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeLevelIndicator : MonoBehaviour
{
    public Text leveltext;
    public GreatTree GreatTree;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leveltext.text = "TreeLevel: " + GreatTree.CheckTreeLevel();


    }



    
}
