﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreatTree : MonoBehaviour
{
    public Text uiTreeHealth;

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
        uiTreeHealth.text = "Tree Health: " + currentHealth;
    }

    public void UpdateHealthOnAttack(int damage)
    {
        currentHealth -= damage;
        uiTreeHealth.text = "Tree Health: " + currentHealth;
    }

    public void TreeLevelUp()
    {
        TreeLevel++;
    }

    public int CheckTreeLevel()
    {
        return TreeLevel;
    }
}
