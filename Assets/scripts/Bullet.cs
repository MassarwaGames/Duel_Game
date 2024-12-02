using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private string targetTag = "Player"; // The tag used to identify players

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            Debug.Log($"Bullet hit {collision.gameObject.name}");
            collision.GetComponent<PlayerHealth>()?.TakeDamage(); // Apply damage
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
