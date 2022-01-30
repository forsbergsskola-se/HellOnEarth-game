using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningScript : MonoBehaviour
{
    public int damage = 40;
    // int for damage
    public float speed = 20f;
    private Rigidbody2D rb;
    public PlayerHealth playerHealth;
    private Vector3 direction;
    private GameObject oden;
    private Collider2D collider2D;
    [SerializeField] private LayerMask playerLayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
        oden = GameObject.Find("Target");
        direction = (oden.transform.position - transform.position).normalized;
        transform.up = -direction;
        rb.velocity = direction * speed;
    }
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        // PlayerHealth enemy = hitInfo.GetComponent<PlayerHealth>();
        // // Grabs the enemyHealth script component
        // if (enemy != null)
        // {
        //     enemy.TakeDamage();
        //     Destroy(gameObject);
        // }
        
        if (collider2D.IsTouchingLayers(playerLayer))
        {
            playerHealth.currentHealth -= damage;
                playerHealth.TakeDamage();
                Destroy(gameObject);
        }
    }
}
