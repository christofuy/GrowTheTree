using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    public Transform attackSource;
    public WeaponStats weaponStats;
    public SpriteRenderer sr;
    private float nextAttackTime = 0f;

    public bool Attack(LayerMask enemyLayers){
        if(!CanAttack()) return false;
        if(animator){
            animator.SetTrigger("Attack");
        }
        switch(weaponStats.type){
            case WeaponType.MELEE:
                SoundManager.PlaySound("swordswing");
                MeleeAttack(enemyLayers);
                break;
            case WeaponType.RANGED:
                SoundManager.PlaySound("magicshoot");
                FireProjectile();
                break;
        }
        UpdateNextAttackTime();
        return true;
    }

    void OnDrawGizmosSelected(){
        if(attackSource==null) return;
        Gizmos.DrawWireSphere(attackSource.position,weaponStats.meleeAttackRange);
    }

    private void MeleeAttack(LayerMask enemyLayers){
        Collider2D[] hitEnemies=Physics2D.OverlapCircleAll(attackSource.position,weaponStats.meleeAttackRange,enemyLayers);
        if(hitEnemies.Length > 0){
            Enemy firstEnemy = hitEnemies[0].GetComponent<Enemy>();
            if(firstEnemy){
                firstEnemy.TakeDamage(weaponStats.damageModifier);
            }
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