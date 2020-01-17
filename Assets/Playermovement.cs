﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigid;
    public float Movespeed = 5;
    public float Jumppower = 5;
    void Awake()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newVelocity = rigid.velocity;
        newVelocity.x = Input.GetAxis("Horizontal") * Movespeed;
        if (Input.GetKeyDown(KeyCode.Z)) {
            newVelocity.y = Jumppower;
        }
        rigid.velocity = newVelocity;
        
    }
    bool isGrounded() {

    }
}
