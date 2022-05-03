﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MagicBar magicbar;

    void Start()
    {

    }

    public void OnTermiteAttackPlayer(int damage)
    {
        print("Player was attacked!");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            magicbar.GainMagic();
            Destroy(collision.gameObject);
        }
    }
}
