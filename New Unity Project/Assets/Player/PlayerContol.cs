// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerContol.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerContol : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerContol()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerContol"",
    ""maps"": [
        {
            ""name"": ""PlayerMovemant"",
            ""id"": ""5264dd10-8d81-449e-bd4d-b450335d4e53"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovemant"",
                    ""type"": ""PassThrough"",
                    ""id"": ""39524e2a-6968-43a1-ad36-21aa288fb913"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""abefcd87-01ad-46e0-97e9-458af26d531e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd7fc2ea-b9e7-403a-bcfa-836d1042bf2b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""44babd26-405c-45d8-80ab-8babc7e89e4f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""7db24991-632e-4da2-b02e-a4d0f4e607d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ccfdffea-e7af-4849-967b-43512cc116ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovemant"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6693b110-fcde-418b-8744-15a2d7eb7c82"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovemant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e05620f7-6a06-42bb-876a-455d9938ca30"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovemant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""220220eb-6e49-4b1b-b540-6b2caebf346e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovemant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e1a15a67-4fbe-424f-a4ad-843f313eba35"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovemant"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a5c25464-cdfc-4476-a5e6-88830347b4d1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7559901b-a30e-44fb-9383-cfb8593359d7"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76bbaf62-aaaa-4403-9b6d-b9aa3c61645c"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1937f791-9610-4b91-9024-328e24580df1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovemant
        m_PlayerMovemant = asset.FindActionMap("PlayerMovemant", throwIfNotFound: true);
        m_PlayerMovemant_HorizontalMovemant = m_PlayerMovemant.FindAction("HorizontalMovemant", throwIfNotFound: true);
        m_PlayerMovemant_Jump = m_PlayerMovemant.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovemant_MouseX = m_PlayerMovemant.FindAction("MouseX", throwIfNotFound: true);
        m_PlayerMovemant_MouseY = m_PlayerMovemant.FindAction("MouseY", throwIfNotFound: true);
        m_PlayerMovemant_Shot = m_PlayerMovemant.FindAction("Shot", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerMovemant
    private readonly InputActionMap m_PlayerMovemant;
    private IPlayerMovemantActions m_PlayerMovemantActionsCallbackInterface;
    private readonly InputAction m_PlayerMovemant_HorizontalMovemant;
    private readonly InputAction m_PlayerMovemant_Jump;
    private readonly InputAction m_PlayerMovemant_MouseX;
    private readonly InputAction m_PlayerMovemant_MouseY;
    private readonly InputAction m_PlayerMovemant_Shot;
    public struct PlayerMovemantActions
    {
        private @PlayerContol m_Wrapper;
        public PlayerMovemantActions(@PlayerContol wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovemant => m_Wrapper.m_PlayerMovemant_HorizontalMovemant;
        public InputAction @Jump => m_Wrapper.m_PlayerMovemant_Jump;
        public InputAction @MouseX => m_Wrapper.m_PlayerMovemant_MouseX;
        public InputAction @MouseY => m_Wrapper.m_PlayerMovemant_MouseY;
        public InputAction @Shot => m_Wrapper.m_PlayerMovemant_Shot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovemant; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovemantActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovemantActions instance)
        {
            if (m_Wrapper.m_PlayerMovemantActionsCallbackInterface != null)
            {
                @HorizontalMovemant.started -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnHorizontalMovemant;
                @HorizontalMovemant.performed -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnHorizontalMovemant;
                @HorizontalMovemant.canceled -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnHorizontalMovemant;
                @Jump.started -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnMouseY;
                @Shot.started -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_PlayerMovemantActionsCallbackInterface.OnShot;
            }
            m_Wrapper.m_PlayerMovemantActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovemant.started += instance.OnHorizontalMovemant;
                @HorizontalMovemant.performed += instance.OnHorizontalMovemant;
                @HorizontalMovemant.canceled += instance.OnHorizontalMovemant;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
            }
        }
    }
    public PlayerMovemantActions @PlayerMovemant => new PlayerMovemantActions(this);
    public interface IPlayerMovemantActions
    {
        void OnHorizontalMovemant(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
    }
}
