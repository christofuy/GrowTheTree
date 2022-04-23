using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        // instantiate hit effect here, and clean up hit effect after
        Destroy(gameObject);
    }
}
