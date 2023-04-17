using UnityEngine;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{

    public Timer timer;
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collisionInfo.collider.GetComponent<PlayerInventory>();
            if (playerInventory.collectedKey)
            {
                gameObject.SetActive(false) ;
                FindObjectOfType<AudioManager>().Play("Lock");
                int level_complete_score = (timer.totalTime - (int)timer.currTime) * 100;
                PlayerScore.Instance.AddScore(level_complete_score);
                Invoke("NextLevel", 2);
            }
            
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
