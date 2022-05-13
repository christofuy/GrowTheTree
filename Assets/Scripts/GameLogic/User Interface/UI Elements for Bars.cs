using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElementsforBars : MonoBehaviour
{
    public TreeHealthBar TreeHealthBar;
    public MagicBar MagicBar;
    public PlayerHealthBar PlayerHealthBar;

    public Text text_TreeHealth;
    public Text text_PlayerMagic;
    public Text text_PlayerHealth;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_TreeHealth.text = "" + TreeHealthBar.currentTreeHealth;
        text_PlayerMagic.text = "";
        text_PlayerHealth.text = "";
    }
}
