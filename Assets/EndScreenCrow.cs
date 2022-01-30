using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenCrow : MonoBehaviour
{
    [SerializeField]private float birdSlowTime;
    [SerializeField]private float speed;
    [SerializeField] private Rigidbody2D rb;
    private Animator animator;
    private bool couroutineStarted = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.right * speed * Time.fixedDeltaTime);
    }

    void Update()
    {
        if (couroutineStarted) return;
        StartCoroutine(BirdFloop());
        
    }
    IEnumerator BirdFloop()
    {
        couroutineStarted = true;
        
        speed = 300f;
        animator.speed = 1.4f;
        yield return new WaitForSeconds(8);
        speed = -200f;
        animator.speed = 0.9f;
        yield return new WaitForSeconds(3);
        speed = 300f;
        animator.speed = 1.4f;
        yield return new WaitForSeconds(5);
        speed = -300f;
        animator.speed = 0.6f;
        yield return new WaitForSeconds(10);
        
        couroutineStarted = false;
    }
}
