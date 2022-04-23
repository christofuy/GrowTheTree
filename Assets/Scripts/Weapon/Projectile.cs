using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public GameObject impactEffect;

    void OnCollisionEnter2D(Collision2D collision){
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if(enemy!=null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
