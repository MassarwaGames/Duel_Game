using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3; // Maximum health
    private int currentHealth; // Current health during gameplay

    [SerializeField] private TextMeshProUGUI healthText; // Reference to the player's health text

    private void Start()
    {
        currentHealth = maxHealth; // Initialize health
        UpdateHealthUI(); // Initialize the health display
    }

    public void TakeDamage()
    {
        currentHealth--; // Reduce health
        Debug.Log($"{gameObject.name} took damage! Remaining health: {currentHealth}");
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die(); // Handle player defeat
        }
    }

    private void UpdateHealthUI()
    {
        healthText.text = $"{gameObject.name} Health: {currentHealth}";
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} has been defeated!");
        GameManager.Instance.EndGame(gameObject.name == "Player1" ? "Player2" : "Player1");
        Destroy(gameObject);
    }
}
