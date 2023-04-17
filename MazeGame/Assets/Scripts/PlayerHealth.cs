using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public float currentHealth;

    public LifeBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.MaxHealth(maxHealth);
    }

    public void Damage(float damageAmount)
    {
        currentHealth -= damageAmount;
        healthBar.SetHealth((int)currentHealth);
        if (currentHealth <= 0)
        {
            Leaderboard.Record("player", PlayerScore.Instance.score);
            PlayerScore.Instance.ResetScore();
            SceneManager.LoadScene("MainMenu");
        }
        healthBar.SetHealth((int)currentHealth);
    }
}
