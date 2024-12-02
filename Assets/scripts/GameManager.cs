using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton for global access

    [SerializeField] private TextMeshProUGUI winText; // Reference to the WinText UI

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Ensure only one GameManager exists
        }
    }

    public void EndGame(string winner)
    {
        Debug.Log($"{winner} wins the game!");

        // Display the win message
        winText.text = $"{winner} Wins!";
        winText.gameObject.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;
    }
}
