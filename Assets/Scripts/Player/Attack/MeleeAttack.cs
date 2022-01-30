using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private float _timeBtwAttacks;
    [SerializeField] private Animator animator;
    public Transform attackPos;
    public LayerMask enemyMask;
    public float attackRange;
    public int damage;
    public float attackSpeed = 1f;
    private float attackCD = 0f;
    public bool isAttacking = false;
    void Update()
    {
        if (Time.time >= attackCD)
        {
            if (Input.GetButton("Fire1"))
            {
                isAttacking = true;
                attackCD = Time.time + 1f / attackSpeed;
                animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemyMask);
                foreach (var enemy in enemiesToDamage)
                {
                    enemy.GetComponent<EnemyBase>().health -= damage;
                    enemy.GetComponent<FlyingEnemyBase>().health -= damage;
                }
            }
            else isAttacking = false;
        }
        else
        {
            
            _timeBtwAttacks -= Time.deltaTime;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
