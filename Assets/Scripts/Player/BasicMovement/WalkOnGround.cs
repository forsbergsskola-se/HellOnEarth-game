using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOnGround : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float gravity;
    [SerializeField] private MeleeAttack attackScript;
    [SerializeField] public Vector2 movement;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    private float odenTransform = 1f;
    
    void Update()
    {
        if (attackScript.isAttacking) return;
        movement.x = Input.GetAxisRaw("Horizontal");
        if (movement.x < -0.01f) odenTransform = 1;
        else if (movement.x > 0.01f) odenTransform = -1;
        transform.localScale = new Vector3(odenTransform, 1 , 1) ;
        movement = movement.normalized;
        animator.SetFloat("Speed", movement.sqrMagnitude);
        rb.velocity = new Vector2(movementSpeed * movement.x, rb.velocity.y + gravity);
    }
}
