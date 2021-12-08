using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
#pragma warning disable 649
    [SerializeField] Movemant movemant;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] Gun gun;
    PlayerContol controls;
    PlayerContol.PlayerMovemantActions playerMovemant;

    Vector2 horizontalInput;
    Vector2 mouseInput;
    private void Awake()
    {
        controls = new PlayerContol();
        playerMovemant = controls.PlayerMovemant;
        playerMovemant.HorizontalMovemant.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        playerMovemant.Jump.performed += _ => movemant.OnJumpPressed();
        playerMovemant.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        playerMovemant.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
        playerMovemant.Shot.performed += _ => gun.Shot(); 

    }
    private void Update()
    {
        movemant.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable() 
    {
        controls.Disable();
    }
}
