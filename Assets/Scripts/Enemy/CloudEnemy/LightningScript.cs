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
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
 
    void Start()
    {
        Vector3 Direction = (FindObjectOfType<PlayerHealth>().transform.position - transform.position).normalized;
        rb.velocity = Direction * speed;
        transform.up = -Direction;
        playerHealth = GameObject.Find("Player (1)").GetComponent<PlayerHealth>();
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
        if (hitInfo.CompareTag("Player"))
        {
            playerHealth.currentHealth -= damage;
            playerHealth.TakeDamage();
        }
    }
}
