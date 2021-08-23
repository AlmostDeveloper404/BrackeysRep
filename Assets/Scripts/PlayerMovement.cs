using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController _characterController;
    [SerializeField] float speed = 20f; 

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = (transform.right * horizontal + transform.forward * vertical).normalized;
        _characterController.Move(dir*speed*Time.deltaTime);
    }
}
