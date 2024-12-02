using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Vector2 bulletVelocity = new Vector2(10f, 0f);
    [SerializeField] private InputAction shootAction;

    private void OnEnable()
    {
        shootAction.Enable();
    }

    private void OnDisable()
    {
        shootAction.Disable();
    }

    private void Update()
    {
        if (shootAction.WasPressedThisFrame())
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the shoot point
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        // Determine direction based on player's rotation
        Vector3 direction = transform.right; // Assumes player faces right
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * bulletVelocity.x;
    }
}
