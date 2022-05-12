using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public MagicBar magicBar;
    public LayerMask enemyLayers;
    public Weapon primaryWeapon;
    public Weapon secondaryWeapon;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            primaryWeapon.Attack(enemyLayers);
        }else if (Input.GetButtonDown("Fire2")){
            if(magicBar.GetCurrMagicPoints() >= secondaryWeapon.weaponStats.mpCost){
                bool didAttack = secondaryWeapon.Attack(enemyLayers);
                if(didAttack)
                    magicBar.ConsumeMagicPoints(secondaryWeapon.weaponStats.mpCost);
            }
        }
    }
}