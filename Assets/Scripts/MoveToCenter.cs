using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCenter : MonoBehaviour
{
    public GameObject tree;
    public float speed = 1f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, tree.transform.position, speed * Time.deltaTime);
    }
}
