using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private float timeBtwAttacks;
    public float startTimeBtwAttacks;

    public Transform attackPos;
    public LayerMask enemyMask;
    public float attackRange;

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttacks <= 0)
        {
            if (Input.GetButton("Fire1"))
            {
                timeBtwAttacks = startTimeBtwAttacks;
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemyMask);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().health -= damage;
                }
            }
        }
        else
        {
            timeBtwAttacks -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
