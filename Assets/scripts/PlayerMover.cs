using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private string horizontalInput = "Horizontal";
    [SerializeField] private string verticalInput = "Vertical";

    void Update()
    {
        float moveX = Input.GetAxis(horizontalInput) * speed * Time.deltaTime;
        float moveY = Input.GetAxis(verticalInput) * speed * Time.deltaTime;

        transform.Translate(new Vector3(moveX, moveY, 0));
    }
}
