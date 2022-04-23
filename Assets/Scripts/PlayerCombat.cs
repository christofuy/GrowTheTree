using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public LayerMask enemyLayers;
    public Weapon weapon;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            weapon.Attack(enemyLayers);
        }
    }
}