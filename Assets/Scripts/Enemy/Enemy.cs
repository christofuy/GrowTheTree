using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    public int maxHealth = 100;
    private int currHealth;

    public GameObject deathEffect;

    protected virtual void Start()
    {
        this.currHealth = this.maxHealth;
    }

    public void TakeDamage(int damage){
        this.currHealth -= damage;
        if(currHealth <= 0){
            Die();
        }
    }

    private void Die(){
        Destroy(gameObject);
        Instantiate(deathEffect,transform.position,Quaternion.identity);
    }
}
