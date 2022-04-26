using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Termite : MonoBehaviour
{
    public GameObject tree;
    public SpriteRenderer spriteRenderer;
    public float speed = 1f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, tree.transform.position, speed * Time.deltaTime);
        Rotate(transform.position);
    }


    private void Rotate(Vector3 directionVector)
    {
        float newAngle = (float)ScreenPositionTools.VectorToAngle(directionVector);
        spriteRenderer.transform.eulerAngles = new Vector3(0, 0, newAngle - 180);
    }

}
