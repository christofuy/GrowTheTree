using UnityEngine;

public class Termite : Enemy
{
    GameObject tree;
    GreatTree greatTree;
    public SpriteRenderer spriteRenderer;

    public float attackRange = 2f;
    public float attackRate = 1f;
    public int attackDamage = 10;
    public float speed = 1f;

    private Animator animator;
    private bool isWalking = false;
    private bool isInRange = false;
    private float nextAttackTime = 0f;

    void Start()
    {
        this.animator=gameObject.GetComponent<Animator>();
        this.tree = GameObject.FindGameObjectWithTag("Tree");
        this.greatTree = tree.GetComponent<GreatTree>();
    }

    void Update()
    {
        if(this.isInRange){
            if(CanAttack())
                this.Attack();
        }else{
            MoveToTarget(this.tree.transform.position);
            float distance = Vector2.Distance(this.transform.position, tree.transform.position);
            this.isInRange = distance < this.attackRange;
            Rotate(transform.position);
        }
    }

    private void MoveToTarget(Vector3 target)
    {
        bool wasWalking=this.isWalking;
        this.isWalking=true;
        if(!wasWalking)
            this.animator.SetBool("isWalking",true);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void Rotate(Vector3 directionVector)
    {
        float newAngle = (float)ScreenPositionTools.VectorToAngle(directionVector);
        spriteRenderer.transform.eulerAngles = new Vector3(0, 0, newAngle - 180);
    }

    private void Attack(){
        bool wasWalking = this.isWalking;
        this.isWalking=false;
        if(wasWalking)
            animator.SetBool("isWalking",false);
        animator.SetTrigger("Attack");

        this.greatTree.UpdateHealthOnAttack(attackDamage);

        UpdateNextAttackTime();
    }

    private bool CanAttack(){
        return Time.time >= nextAttackTime;
    }

    private void UpdateNextAttackTime(){
        this.nextAttackTime = Time.time + 1f / this.attackRate;
    }
}
