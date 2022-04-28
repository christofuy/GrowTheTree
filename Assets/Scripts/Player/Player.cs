using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxMagic = 100;
    public int currentMagic = 0;
    public MagicBar magicbar;

    void Start()
    {
        currentMagic = maxMagic;
        magicbar.SetMaxMagic();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            magicbar.GainMagic(currentMagic);
            print("Collected fruit");
        }
    }
}
