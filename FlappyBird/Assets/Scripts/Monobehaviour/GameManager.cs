using UnityEngine;
using UnityEngine.UI; // Add this if you'll display the score in UI
using TMPro;

public class GameManager : MonoBehaviour
{
    // singleton
    public static GameManager instance;
    
    public int score;
    public TMP_Text scoreText; // Or public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
        score = 0;
    }

    public void IncrementScore()
    {
        score++;
        
        // Update UI if you have a score display
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
        
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }
}
