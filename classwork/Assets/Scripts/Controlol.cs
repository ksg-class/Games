// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controlol.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controlol : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controlol()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controlol"",
    ""maps"": [
        {
            ""name"": ""Userlol"",
            ""id"": ""8430067f-65d2-4af7-acbb-9fc3952bc3df"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a2a1d9bd-60d4-48b8-acf4-c83bfe1a671d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7f898ff1-767c-4a28-a498-81cfec19a24e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""56398910-29c9-4e27-9738-ac4e6b2190ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a36360e-b4ce-4688-837a-385d90c87d82"",
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
                    ""id"": ""42863539-7d2e-49ff-a24f-724576060e67"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d9d6a155-5868-4a84-93ed-049d32a78759"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8a9ec674-a91a-433a-9475-5f470c0c34dc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0b90e1f5-3cc2-4510-b0be-ffffbe9eba6d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""882be93b-7bbd-4e13-bb9c-a8faaa5707f8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8a0a6bd8-9f71-4d99-844f-6e68a66d0024"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9343d0bc-66fb-406b-889d-704895e8dea8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ad5ac5dc-edcd-4fcf-a2bc-00c2d2c256dd"",
                    ""path"": ""<AndroidJoystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fdb0bbbd-a7e0-4340-b25b-b891bc25c9f2"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8cc6379e-3c6d-468f-9dbe-242b5153486a"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3abcb2aa-fc97-45f2-bd9f-a16b5a3a78b3"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Userlol
        m_Userlol = asset.FindActionMap("Userlol", throwIfNotFound: true);
        m_Userlol_Jump = m_Userlol.FindAction("Jump", throwIfNotFound: true);
        m_Userlol_Move = m_Userlol.FindAction("Move", throwIfNotFound: true);
        m_Userlol_Shoot = m_Userlol.FindAction("Shoot", throwIfNotFound: true);
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

    // Userlol
    private readonly InputActionMap m_Userlol;
    private IUserlolActions m_UserlolActionsCallbackInterface;
    private readonly InputAction m_Userlol_Jump;
    private readonly InputAction m_Userlol_Move;
    private readonly InputAction m_Userlol_Shoot;
    public struct UserlolActions
    {
        private @Controlol m_Wrapper;
        public UserlolActions(@Controlol wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Userlol_Jump;
        public InputAction @Move => m_Wrapper.m_Userlol_Move;
        public InputAction @Shoot => m_Wrapper.m_Userlol_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Userlol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserlolActions set) { return set.Get(); }
        public void SetCallbacks(IUserlolActions instance)
        {
            if (m_Wrapper.m_UserlolActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_UserlolActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_UserlolActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_UserlolActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_UserlolActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UserlolActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UserlolActionsCallbackInterface.OnMove;
                @Shoot.started -= m_Wrapper.m_UserlolActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_UserlolActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_UserlolActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_UserlolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public UserlolActions @Userlol => new UserlolActions(this);
    public interface IUserlolActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
