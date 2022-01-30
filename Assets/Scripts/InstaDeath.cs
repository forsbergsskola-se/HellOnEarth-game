using UnityEngine;

public class InstaDeath : MonoBehaviour
{
    public float damage = 200f;
    public PlayerHealth playerHealth;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            playerHealth.currentHealth -= damage;
            playerHealth.TakeDamage();
        }
    }
}