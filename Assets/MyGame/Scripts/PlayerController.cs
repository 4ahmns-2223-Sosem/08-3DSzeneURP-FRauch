using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed;

        characterController.Move(movement * Time.deltaTime);
    }
}
