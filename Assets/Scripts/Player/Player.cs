using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public MagicBar magicbar;
    public PlayerHealthBar playerhealth;
    public TreeHealthBar treehealth;

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
            SoundManager.PlaySound("collect");
            magicbar.GainMagic();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Heart")
        {
            SoundManager.PlaySound("collect");
            playerhealth.GainPlayerHealth();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Petal")
        {
            SoundManager.PlaySound("collect");
            treehealth.GainTreeHealth();
            print("Tree gained 10 health!");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Poison")
        {
            SoundManager.PlaySound("poisoncollect");
            playerhealth.LosePlayerHealth();
            print("Player took poison!");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            playerhealth.LosePlayerHealth();
            print("Player was attacked!");
            StartCoroutine(WaitToBeDamaged());
        }
    }

    IEnumerator WaitToBeDamaged()
    {
        yield return new WaitForSeconds(2);
    }
}
