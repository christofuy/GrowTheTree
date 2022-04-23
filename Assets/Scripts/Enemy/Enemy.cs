using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    private int currHealth;
    public GameObject deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        this.currHealth -= damage;
        if(currHealth <= 0){
            Die();
        }
    }

    private void Die(){
        Debug.Log("Enemy Died");
        Destroy(gameObject);
        Instantiate(deathEffect,transform.position,Quaternion.identity);
    }
}
