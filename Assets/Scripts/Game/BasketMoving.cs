using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMoving : MonoBehaviour
{
    float horizontal, speed = 500f;
    Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = transform.TransformDirection(new Vector3(horizontal*speed*Time.deltaTime, 0, 0));
    }
}
