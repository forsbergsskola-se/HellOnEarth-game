using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private float _timeBtwAttacks;
    public float startTimeBtwAttacks;
    [SerializeField] private Animator animator;
    public Transform attackPos;
    public LayerMask enemyMask;
    public float attackRange;
    public int damage;

    // Update is called once per frame
    void Update()
    {
        if (_timeBtwAttacks <= 0)
        {
            if (Input.GetButton("Fire1"))
            {
                _timeBtwAttacks = startTimeBtwAttacks;
                animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemyMask);
                foreach (var enemy in enemiesToDamage)
                {
                    enemy.GetComponent<EnemyBase>().health -= damage;
                }
            }
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
