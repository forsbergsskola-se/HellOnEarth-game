using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public int damage = 40;
    // int for damage
    public float speed = 20f;
    private Rigidbody2D rb;
    
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
 
    void Start() 
    {
        rb.velocity = (FindObjectOfType<PlayerHealth>().transform.position - transform.position).normalized * speed;
    }
    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        PlayerHealth enemy = hitInfo.GetComponent<PlayerHealth>();
        // Grabs the enemyHealth script component
        if (enemy != null)
        {
            enemy.TakeDamage();
            Destroy(gameObject);
        }

    }
}
