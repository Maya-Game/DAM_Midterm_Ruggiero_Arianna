
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    public InputAction moveRight;
    public InputAction moveLeft;
    public Rigidbody2D body2D;

    public float moveSpeed = 5;
    public float slowDownMultiplier = 0.9f;

    public float minYLimit = -3.30f;
    public float maxYLimit = 3.30f;

    public void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
    }
    public void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
    }

    private void Update()
    {
        if (moveRight.IsPressed() || moveLeft.IsPressed())
        {

            if (moveRight.IsPressed())
            {
                body2D.linearVelocityY = moveSpeed;
            }

            if (moveLeft.IsPressed())
            {
                body2D.linearVelocityY = -moveSpeed;
            }
        }

    }
}
