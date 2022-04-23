using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform attackSource;
    public WeaponStats weaponStats;
    public SpriteRenderer sr;

    void Start(){
        UpdateWeaponSprite(weaponStats.sprite);
    }

    public void Attack(LayerMask enemyLayers){
        switch(weaponStats.type){
            case WeaponType.MELEE:
                MeleeAttack(enemyLayers);
                break;
            case WeaponType.RANGED:
                FireProjectile();
                break;
        }
    }

    void OnDrawGizmosSelected(){
        if(attackSource==null) return;
        Gizmos.DrawWireSphere(attackSource.position,weaponStats.meleeAttackRange);
    }

    private void MeleeAttack(LayerMask enemyLayers){
        Debug.Log("Melee Attack Ran");
        Collider2D[] hitEnemies=Physics2D.OverlapCircleAll(attackSource.position,weaponStats.meleeAttackRange,enemyLayers);
        foreach(Collider2D enemy in hitEnemies){
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(weaponStats.damageModifier);
        }
    }

    private void FireProjectile(){
        GameObject projectile=Instantiate(weaponStats.projectilePrefab,attackSource.position,attackSource.rotation);
        Rigidbody2D rb=projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(attackSource.up * weaponStats.projectileForce,ForceMode2D.Impulse);
    }

    private void UpdateWeaponSprite(Sprite sprite){
        sr.sprite=sprite;
    }
}