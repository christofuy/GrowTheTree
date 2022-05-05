using UnityEngine;

public enum WeaponType {MELEE, RANGED};

[CreateAssetMenu(fileName = "New Weapon Stats", menuName = "WeaponStats")]
public class WeaponStats : ScriptableObject
{
    new public string name = "Weapon Name";
    public WeaponType type;
    public Sprite sprite = null;
    public float attackRate = 1f;
    public int damageModifier;
    public float meleeAttackRange = 0.5f;
    public float projectileForce = 20f;
    public GameObject projectilePrefab;
}