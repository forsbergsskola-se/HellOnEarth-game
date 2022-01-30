using UnityEngine;
public class HealthPickup : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public float addHealth;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth.currentHealth < 100)
            {
                playerHealth.currentHealth += addHealth;
                playerHealth.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}