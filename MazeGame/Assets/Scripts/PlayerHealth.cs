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
            PlayerScore.Instance.ResetScore();
            Invoke("PreviousLevel", 1);
        }
        healthBar.SetHealth((int)currentHealth);
    }

    public void PreviousLevel()
    {
        if (PlayerScore.Instance.score <= 2000)
        {
            PlayerScore.Instance.ResetScore();
        }
        else
            PlayerScore.Instance.AddScore(-2000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
