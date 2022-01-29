using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOnGround : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float gravity;
    [SerializeField] private Vector2 movement;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement = movement.normalized;
        
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetFloat("Horizontal", movement.x);
        rb.velocity = new Vector2(movementSpeed * movement.x, rb.velocity.y + gravity);
        //rb.velocity = rb.position + movement * movementSpeed * Time.time;
    }
}
