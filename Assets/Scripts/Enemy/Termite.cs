using UnityEngine;

public class Termite : Enemy
{
    public GameObject tree;
    public GameObject AttackPoint;
    public SpriteRenderer spriteRenderer;

    private Animator animator;
    private bool isWalking = false;

    public float speed = 1f;
    Vector3 target;


    void Start()
    {
        this.animator=gameObject.GetComponent<Animator>();
        target = new Vector3(tree.transform.position.x, tree.transform.position.y, tree.transform.position.z);
    }

    void Update()
    {
        MoveToTarget(target);
        Rotate(transform.position);
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
}
