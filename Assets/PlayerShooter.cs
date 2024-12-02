using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Vector2 bulletVelocity = new Vector2(10f, 0f);
    [SerializeField] private KeyCode shootKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = bulletVelocity * (transform.localScale.x > 0 ? 1 : -1);
    }
}
