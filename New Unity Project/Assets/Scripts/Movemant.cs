using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemant : MonoBehaviour
{
#pragma warning disable 649
#pragma warning disable 229
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    [SerializeField] float gravity = -30f;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float jumpHeight = 3.5f;
    [SerializeField] MouseLook mouseLook;

    
    Vector2 horizontalInput;
    Vector2 mouseInput;
        
    Vector3 verticalVelocity = Vector3.zero;
    bool isGrounded;
    bool jump;


    private void Update()
    {
#pragma warning disable 649
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded)
        {
            verticalVelocity.y = 0f;
        }
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
        //Jump: velocity= (שורש)squreRoot(-2 * jumpHeight * GRavity)
        if (jump)
        {
            if (isGrounded)
            {
                verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
            }
            jump = false;
        }
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }
    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
      
    }
    public void OnJumpPressed()
    {
        jump = true;
    }
}
