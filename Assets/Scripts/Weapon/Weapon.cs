using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    public Transform attackSource;
    public WeaponStats weaponStats;
    public SpriteRenderer sr;
    private float nextAttackTime = 0f;

    public void Attack(LayerMask enemyLayers){
        if(!CanAttack()) return;
        if(animator){
            animator.SetTrigger("Attack");
        }
        switch(weaponStats.type){
            case WeaponType.MELEE:
                MeleeAttack(enemyLayers);
                break;
            case WeaponType.RANGED:
                FireProjectile();
                break;
        }
        UpdateNextAttackTime();
    }

    void OnDrawGizmosSelected(){
        if(attackSource==null) return;
        Gizmos.DrawWireSphere(attackSource.position,weaponStats.meleeAttackRange);
    }

    private void MeleeAttack(LayerMask enemyLayers){
        Collider2D[] hitEnemies=Physics2D.OverlapCircleAll(attackSource.position,weaponStats.meleeAttackRange,enemyLayers);
        if(hitEnemies.Length > 0){
            Collider2D firstEnemy = hitEnemies[0];
            firstEnemy.GetComponent<Enemy>().TakeDamage(weaponStats.damageModifier);
        }
    }

    private void FireProjectile(){
         GameObject projectile = Instantiate(weaponStats.projectilePrefab, attackSource.position, attackSource.rotation);
         Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
         rb.AddForce(attackSource.up * weaponStats.projectileForce, ForceMode2D.Impulse);
    }

    private void UpdateWeaponSprite(Sprite sprite){
        sr.sprite=sprite;
    }

    private bool CanAttack(){
        return Time.time >= nextAttackTime;
    }

    private void UpdateNextAttackTime(){
        nextAttackTime = Time.time + 1f / weaponStats.attackRate;
    }
}