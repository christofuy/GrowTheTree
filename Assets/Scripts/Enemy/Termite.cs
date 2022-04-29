using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Termite : Enemy
{
    public GameObject tree;
    public SpriteRenderer spriteRenderer;
    public float speed = 1f;
    private int attackCoolDownTimeSeconds = 2;


    public LayerMask opposingLayers;
    public Weapon weapon;

    bool canAttack = false;

    Vector3 target;


    void Start()
    {
        target = new Vector3(tree.transform.position.x, tree.transform.position.y, tree.transform.position.z);
    }

    void Update()
    {
        MoveToTarget(target);
        Rotate(transform.position);
        if (canAttack)
        {
            print("termite attacked!");
            //weapon.Attack(opposingLayers);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        canAttack = true;
        StartCoroutine(AttackCooldown());
        //Start coRoutine timer to make canAttack false after a moment.
    }

    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(attackCoolDownTimeSeconds);
        canAttack = false;
    }

    //Need a function that sets "canAttack" to false after two? seconds if canAttack is made true


    private void MoveToTarget(Vector3 target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void Rotate(Vector3 directionVector)
    {
        float newAngle = (float)ScreenPositionTools.VectorToAngle(directionVector);
        spriteRenderer.transform.eulerAngles = new Vector3(0, 0, newAngle - 180);
    }
}
