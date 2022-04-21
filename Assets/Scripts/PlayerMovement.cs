using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed=5f;
    public Rigidbody rb;
    public Camera cam;

    Vector3 movement;
    Vector3 mousePos;

    // Update is called once per frame
    void Update() {
        UpdateMovement();
        UpdateMousePosition();
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position+movement * moveSpeed * Time.fixedDeltaTime);

        Vector3 lookDir=mousePos-rb.position;
        lookDir.z=0;
        rb.rotation=Quaternion.LookRotation(lookDir);
    }

    private void UpdateMovement(){
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");
    }

    private void UpdateMousePosition(){
        mousePos= cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
