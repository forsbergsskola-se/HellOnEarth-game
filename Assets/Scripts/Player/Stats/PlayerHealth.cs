using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public UIHealth healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerDamage();
    }

    public void TakeDamage()
    {
        healthBar.SetHealth(currentHealth);
    }
    void CheckPlayerDamage()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
