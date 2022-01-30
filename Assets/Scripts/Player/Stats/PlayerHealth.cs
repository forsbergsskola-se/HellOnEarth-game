using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public UIHealth healthBar;
    private DeathCount dC;
    public float deathCount;
    // Start is called before the first frame update
    void Start()
    {
        dC = GameObject.FindObjectOfType<DeathCount>();
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
            dC.IncreaseDeaths();
            //gameObject.SetActive(false);
            SceneManager.LoadScene("PlayScene");
        }
    }
}
