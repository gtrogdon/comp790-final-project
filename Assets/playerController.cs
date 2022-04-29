using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{

    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForce=10;

    private CharacterController character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        jumpActionReference.action.performed += OnJump; 
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if(character.velocity[1] == 0.0f)
            character.Move(Vector3.up * jumpForce);
    }
}
