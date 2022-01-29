using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public float withinRange;
    
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        AttackRange();
        CheckDamage();
    }

    private void CheckDamage()
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

    private void OnTriggerEnter2D(Collider2D col)
    {
        
    }
}
