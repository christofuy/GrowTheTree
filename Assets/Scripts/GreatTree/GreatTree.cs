using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreatTree : MonoBehaviour
{
    public SpriteRenderer TreeSpriteRenderer;
    public Sprite TreeLv1;
    public Sprite TreeLv2;
    public Sprite TreeLv3;

    public Text text_TreeHealth;
    public Text text_TreeLevel;

    public int TreeLevel = 0;

    private int TreeHealth = 1000;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = TreeHealth;
        TreeLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        text_TreeHealth.text = "Tree Health: " + currentHealth;
        text_TreeLevel.text = "Tree Level: " + CheckTreeLevel();
    }

    public void UpdateHealthOnAttack(int damage)
    {
        currentHealth -= damage;
        text_TreeHealth.text = "Tree Health: " + currentHealth;
    }

    public void TreeLevelUp()
    {
        TreeLevel++;
        if (TreeLevel == 0) 
            TreeSpriteRenderer.sprite = TreeLv1;
        else if (TreeLevel == 1)
            TreeSpriteRenderer.sprite = TreeLv1;
        else if (TreeLevel == 2)
            TreeSpriteRenderer.sprite = TreeLv2;
        else if (TreeLevel == 3)
            TreeSpriteRenderer.sprite = TreeLv3;

    }

    public int CheckTreeLevel()
    {
        return TreeLevel;
    }
}
