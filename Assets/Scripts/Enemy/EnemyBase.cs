using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float health;
    public float damage;
    public float speed;
    public float withinRange;
    
    private Transform playerTransform;
    private Transform bPlayerTransform;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Oden").GetComponent<Transform>();
        bPlayerTransform = GameObject.Find("Bird").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackRange();
        CheckPlayerDamage();
    }

    private void CheckPlayerDamage()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void AttackRange()
    {
        float dist = Vector2.Distance(playerTransform.position, transform.position);
        if (dist <= withinRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(playerTransform.position.x, transform.position.y), speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            playerHealth.currentHealth -= damage;
            playerHealth.TakeDamage();
        }

    }
}
