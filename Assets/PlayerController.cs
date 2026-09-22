using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;

    public float speed = 3f;

    void OnEnable()
    {
        moveAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0f);

        transform.position += new Vector3(0f, movement.y, 0f) * speed * Time.deltaTime;
    }
}