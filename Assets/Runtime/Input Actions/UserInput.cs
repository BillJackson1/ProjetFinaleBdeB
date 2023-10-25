//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Runtime/Input Actions/UserInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UserInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovements"",
            ""id"": ""82992370-7218-401b-af42-90fdad6e3ee5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f88d4c28-73a7-4c54-8b7d-1fa59570fecc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""1e770753-4560-4cdb-b1f9-5ca3e8489bab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Tbag"",
                    ""type"": ""Button"",
                    ""id"": ""5ace6f14-6240-46bc-ad50-a4f836fd1251"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2096698a-6735-4ebe-bb6c-9e07520135f8"",
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
                    ""id"": ""60b638bb-a50d-4c76-b791-028b7283b51a"",
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
                    ""id"": ""c4da49f6-6659-4d11-9779-d257bf5f4f88"",
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
                    ""id"": ""c4bbb0ec-6cc0-4495-aa69-e64d3517f907"",
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
                    ""id"": ""242cc4de-63ef-4c12-9b02-12fd062c194f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2cf2fee-abec-4fcb-aa08-f60ffe5d41ca"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""500607ac-c012-491f-87f3-dfe1989119e3"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tbag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerActions"",
            ""id"": ""de5df4ab-975f-4172-a215-88b603b09595"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c93423db-624a-4814-8ee8-f3955e19484e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""29f18846-6426-460d-9c7c-b431db548fc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TimeWarp"",
                    ""type"": ""Button"",
                    ""id"": ""a839dc7a-1a15-4153-bf3b-26117ebc956b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse Cursor"",
                    ""type"": ""Button"",
                    ""id"": ""2340afbe-3709-432a-8ae6-254ad21436fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""95d17c61-72fc-4909-a7ec-083a326d3a87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a979146-2369-42ca-ba80-e388572e55be"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c1726fb-3076-4707-8b65-7f20a8c31cb9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e121dfa-8575-4f1d-b971-e168abe7f7a7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TimeWarp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e3d0a66-c796-40ab-a0e7-0d4385d082ae"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Cursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ee00df6-c98b-4e55-975d-f509f57c7cd7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AudioOptions"",
            ""id"": ""937da7b6-660f-455f-bbff-7b7794cb8366"",
            ""actions"": [
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""08fdf961-63b0-4818-a1e4-1fd039994588"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""0e217b39-bf91-452d-b93e-a2e5f21bb66f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Previous"",
                    ""type"": ""Button"",
                    ""id"": ""ad759ab4-6688-494f-abc1-35878f2d9a07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""d801fc20-a2e4-494f-9a3e-072902ace114"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""VolumeUp"",
                    ""type"": ""Button"",
                    ""id"": ""22d3707c-b23d-4985-ba10-45547e6c7930"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""VolumeDown"",
                    ""type"": ""Button"",
                    ""id"": ""aef7f438-fa36-43cb-9abb-b728cae56eff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eab3a4be-797e-4b24-8ef1-534207b3f319"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac4a2038-803c-4188-8500-f9dbab68a55c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28ec37f0-0ff9-4d6a-83da-08a4d367492c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de46d215-9a17-4f1a-8492-b7c094bc4733"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebf02059-ed58-4640-b560-2eba2db249ce"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolumeUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61c27d4e-bd5c-4114-9473-fc49b079a0b5"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolumeDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""61679914-a1c4-4f83-9889-bdc29c5a0df9"",
            ""actions"": [
                {
                    ""name"": ""Show or Hide Menu"",
                    ""type"": ""Button"",
                    ""id"": ""32317ce3-7469-40c9-9e8b-36a850915a9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Show or Hide Cheats Menu"",
                    ""type"": ""Button"",
                    ""id"": ""9afba5cd-6487-481a-87a4-0225b0164405"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skip Intro"",
                    ""type"": ""Button"",
                    ""id"": ""ae61b980-42c2-48d4-86ec-dc2f84f9e7e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Previous Video"",
                    ""type"": ""Button"",
                    ""id"": ""2c0c42a2-3a26-49a7-b2d8-2436a2a90380"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Next Video"",
                    ""type"": ""Button"",
                    ""id"": ""8e20c7be-5199-477f-93cb-340120f1682a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38074941-0681-4e21-bccf-90bc97db0bdc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Show or Hide Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d08e51b-4b53-4117-9d9c-32dcfc0f2279"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip Intro"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cb8f206-336b-4d4a-9493-1afe95c92754"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Previous Video"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e27ff7bd-eb92-42d9-859b-fb2b16e9ffbc"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next Video"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f2f09f3-8261-4410-b690-744a27d47f4b"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Show or Hide Cheats Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovements
        m_PlayerMovements = asset.FindActionMap("PlayerMovements", throwIfNotFound: true);
        m_PlayerMovements_Move = m_PlayerMovements.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovements_Dash = m_PlayerMovements.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMovements_Tbag = m_PlayerMovements.FindAction("Tbag", throwIfNotFound: true);
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Shoot = m_PlayerActions.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerActions_Melee = m_PlayerActions.FindAction("Melee", throwIfNotFound: true);
        m_PlayerActions_TimeWarp = m_PlayerActions.FindAction("TimeWarp", throwIfNotFound: true);
        m_PlayerActions_MouseCursor = m_PlayerActions.FindAction("Mouse Cursor", throwIfNotFound: true);
        m_PlayerActions_ChangeWeapon = m_PlayerActions.FindAction("ChangeWeapon", throwIfNotFound: true);
        // AudioOptions
        m_AudioOptions = asset.FindActionMap("AudioOptions", throwIfNotFound: true);
        m_AudioOptions_Play = m_AudioOptions.FindAction("Play", throwIfNotFound: true);
        m_AudioOptions_Pause = m_AudioOptions.FindAction("Pause", throwIfNotFound: true);
        m_AudioOptions_Previous = m_AudioOptions.FindAction("Previous", throwIfNotFound: true);
        m_AudioOptions_Next = m_AudioOptions.FindAction("Next", throwIfNotFound: true);
        m_AudioOptions_VolumeUp = m_AudioOptions.FindAction("VolumeUp", throwIfNotFound: true);
        m_AudioOptions_VolumeDown = m_AudioOptions.FindAction("VolumeDown", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_ShoworHideMenu = m_UI.FindAction("Show or Hide Menu", throwIfNotFound: true);
        m_UI_ShoworHideCheatsMenu = m_UI.FindAction("Show or Hide Cheats Menu", throwIfNotFound: true);
        m_UI_SkipIntro = m_UI.FindAction("Skip Intro", throwIfNotFound: true);
        m_UI_PreviousVideo = m_UI.FindAction("Previous Video", throwIfNotFound: true);
        m_UI_NextVideo = m_UI.FindAction("Next Video", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMovements
    private readonly InputActionMap m_PlayerMovements;
    private List<IPlayerMovementsActions> m_PlayerMovementsActionsCallbackInterfaces = new List<IPlayerMovementsActions>();
    private readonly InputAction m_PlayerMovements_Move;
    private readonly InputAction m_PlayerMovements_Dash;
    private readonly InputAction m_PlayerMovements_Tbag;
    public struct PlayerMovementsActions
    {
        private @UserInput m_Wrapper;
        public PlayerMovementsActions(@UserInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMovements_Move;
        public InputAction @Dash => m_Wrapper.m_PlayerMovements_Dash;
        public InputAction @Tbag => m_Wrapper.m_PlayerMovements_Tbag;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @Tbag.started += instance.OnTbag;
            @Tbag.performed += instance.OnTbag;
            @Tbag.canceled += instance.OnTbag;
        }

        private void UnregisterCallbacks(IPlayerMovementsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @Tbag.started -= instance.OnTbag;
            @Tbag.performed -= instance.OnTbag;
            @Tbag.canceled -= instance.OnTbag;
        }

        public void RemoveCallbacks(IPlayerMovementsActions instance)
        {
            if (m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementsActions @PlayerMovements => new PlayerMovementsActions(this);

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private List<IPlayerActionsActions> m_PlayerActionsActionsCallbackInterfaces = new List<IPlayerActionsActions>();
    private readonly InputAction m_PlayerActions_Shoot;
    private readonly InputAction m_PlayerActions_Melee;
    private readonly InputAction m_PlayerActions_TimeWarp;
    private readonly InputAction m_PlayerActions_MouseCursor;
    private readonly InputAction m_PlayerActions_ChangeWeapon;
    public struct PlayerActionsActions
    {
        private @UserInput m_Wrapper;
        public PlayerActionsActions(@UserInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_PlayerActions_Shoot;
        public InputAction @Melee => m_Wrapper.m_PlayerActions_Melee;
        public InputAction @TimeWarp => m_Wrapper.m_PlayerActions_TimeWarp;
        public InputAction @MouseCursor => m_Wrapper.m_PlayerActions_MouseCursor;
        public InputAction @ChangeWeapon => m_Wrapper.m_PlayerActions_ChangeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Melee.started += instance.OnMelee;
            @Melee.performed += instance.OnMelee;
            @Melee.canceled += instance.OnMelee;
            @TimeWarp.started += instance.OnTimeWarp;
            @TimeWarp.performed += instance.OnTimeWarp;
            @TimeWarp.canceled += instance.OnTimeWarp;
            @MouseCursor.started += instance.OnMouseCursor;
            @MouseCursor.performed += instance.OnMouseCursor;
            @MouseCursor.canceled += instance.OnMouseCursor;
            @ChangeWeapon.started += instance.OnChangeWeapon;
            @ChangeWeapon.performed += instance.OnChangeWeapon;
            @ChangeWeapon.canceled += instance.OnChangeWeapon;
        }

        private void UnregisterCallbacks(IPlayerActionsActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Melee.started -= instance.OnMelee;
            @Melee.performed -= instance.OnMelee;
            @Melee.canceled -= instance.OnMelee;
            @TimeWarp.started -= instance.OnTimeWarp;
            @TimeWarp.performed -= instance.OnTimeWarp;
            @TimeWarp.canceled -= instance.OnTimeWarp;
            @MouseCursor.started -= instance.OnMouseCursor;
            @MouseCursor.performed -= instance.OnMouseCursor;
            @MouseCursor.canceled -= instance.OnMouseCursor;
            @ChangeWeapon.started -= instance.OnChangeWeapon;
            @ChangeWeapon.performed -= instance.OnChangeWeapon;
            @ChangeWeapon.canceled -= instance.OnChangeWeapon;
        }

        public void RemoveCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // AudioOptions
    private readonly InputActionMap m_AudioOptions;
    private List<IAudioOptionsActions> m_AudioOptionsActionsCallbackInterfaces = new List<IAudioOptionsActions>();
    private readonly InputAction m_AudioOptions_Play;
    private readonly InputAction m_AudioOptions_Pause;
    private readonly InputAction m_AudioOptions_Previous;
    private readonly InputAction m_AudioOptions_Next;
    private readonly InputAction m_AudioOptions_VolumeUp;
    private readonly InputAction m_AudioOptions_VolumeDown;
    public struct AudioOptionsActions
    {
        private @UserInput m_Wrapper;
        public AudioOptionsActions(@UserInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play => m_Wrapper.m_AudioOptions_Play;
        public InputAction @Pause => m_Wrapper.m_AudioOptions_Pause;
        public InputAction @Previous => m_Wrapper.m_AudioOptions_Previous;
        public InputAction @Next => m_Wrapper.m_AudioOptions_Next;
        public InputAction @VolumeUp => m_Wrapper.m_AudioOptions_VolumeUp;
        public InputAction @VolumeDown => m_Wrapper.m_AudioOptions_VolumeDown;
        public InputActionMap Get() { return m_Wrapper.m_AudioOptions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AudioOptionsActions set) { return set.Get(); }
        public void AddCallbacks(IAudioOptionsActions instance)
        {
            if (instance == null || m_Wrapper.m_AudioOptionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AudioOptionsActionsCallbackInterfaces.Add(instance);
            @Play.started += instance.OnPlay;
            @Play.performed += instance.OnPlay;
            @Play.canceled += instance.OnPlay;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Previous.started += instance.OnPrevious;
            @Previous.performed += instance.OnPrevious;
            @Previous.canceled += instance.OnPrevious;
            @Next.started += instance.OnNext;
            @Next.performed += instance.OnNext;
            @Next.canceled += instance.OnNext;
            @VolumeUp.started += instance.OnVolumeUp;
            @VolumeUp.performed += instance.OnVolumeUp;
            @VolumeUp.canceled += instance.OnVolumeUp;
            @VolumeDown.started += instance.OnVolumeDown;
            @VolumeDown.performed += instance.OnVolumeDown;
            @VolumeDown.canceled += instance.OnVolumeDown;
        }

        private void UnregisterCallbacks(IAudioOptionsActions instance)
        {
            @Play.started -= instance.OnPlay;
            @Play.performed -= instance.OnPlay;
            @Play.canceled -= instance.OnPlay;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Previous.started -= instance.OnPrevious;
            @Previous.performed -= instance.OnPrevious;
            @Previous.canceled -= instance.OnPrevious;
            @Next.started -= instance.OnNext;
            @Next.performed -= instance.OnNext;
            @Next.canceled -= instance.OnNext;
            @VolumeUp.started -= instance.OnVolumeUp;
            @VolumeUp.performed -= instance.OnVolumeUp;
            @VolumeUp.canceled -= instance.OnVolumeUp;
            @VolumeDown.started -= instance.OnVolumeDown;
            @VolumeDown.performed -= instance.OnVolumeDown;
            @VolumeDown.canceled -= instance.OnVolumeDown;
        }

        public void RemoveCallbacks(IAudioOptionsActions instance)
        {
            if (m_Wrapper.m_AudioOptionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAudioOptionsActions instance)
        {
            foreach (var item in m_Wrapper.m_AudioOptionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AudioOptionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AudioOptionsActions @AudioOptions => new AudioOptionsActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_ShoworHideMenu;
    private readonly InputAction m_UI_ShoworHideCheatsMenu;
    private readonly InputAction m_UI_SkipIntro;
    private readonly InputAction m_UI_PreviousVideo;
    private readonly InputAction m_UI_NextVideo;
    public struct UIActions
    {
        private @UserInput m_Wrapper;
        public UIActions(@UserInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShoworHideMenu => m_Wrapper.m_UI_ShoworHideMenu;
        public InputAction @ShoworHideCheatsMenu => m_Wrapper.m_UI_ShoworHideCheatsMenu;
        public InputAction @SkipIntro => m_Wrapper.m_UI_SkipIntro;
        public InputAction @PreviousVideo => m_Wrapper.m_UI_PreviousVideo;
        public InputAction @NextVideo => m_Wrapper.m_UI_NextVideo;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @ShoworHideMenu.started += instance.OnShoworHideMenu;
            @ShoworHideMenu.performed += instance.OnShoworHideMenu;
            @ShoworHideMenu.canceled += instance.OnShoworHideMenu;
            @ShoworHideCheatsMenu.started += instance.OnShoworHideCheatsMenu;
            @ShoworHideCheatsMenu.performed += instance.OnShoworHideCheatsMenu;
            @ShoworHideCheatsMenu.canceled += instance.OnShoworHideCheatsMenu;
            @SkipIntro.started += instance.OnSkipIntro;
            @SkipIntro.performed += instance.OnSkipIntro;
            @SkipIntro.canceled += instance.OnSkipIntro;
            @PreviousVideo.started += instance.OnPreviousVideo;
            @PreviousVideo.performed += instance.OnPreviousVideo;
            @PreviousVideo.canceled += instance.OnPreviousVideo;
            @NextVideo.started += instance.OnNextVideo;
            @NextVideo.performed += instance.OnNextVideo;
            @NextVideo.canceled += instance.OnNextVideo;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @ShoworHideMenu.started -= instance.OnShoworHideMenu;
            @ShoworHideMenu.performed -= instance.OnShoworHideMenu;
            @ShoworHideMenu.canceled -= instance.OnShoworHideMenu;
            @ShoworHideCheatsMenu.started -= instance.OnShoworHideCheatsMenu;
            @ShoworHideCheatsMenu.performed -= instance.OnShoworHideCheatsMenu;
            @ShoworHideCheatsMenu.canceled -= instance.OnShoworHideCheatsMenu;
            @SkipIntro.started -= instance.OnSkipIntro;
            @SkipIntro.performed -= instance.OnSkipIntro;
            @SkipIntro.canceled -= instance.OnSkipIntro;
            @PreviousVideo.started -= instance.OnPreviousVideo;
            @PreviousVideo.performed -= instance.OnPreviousVideo;
            @PreviousVideo.canceled -= instance.OnPreviousVideo;
            @NextVideo.started -= instance.OnNextVideo;
            @NextVideo.performed -= instance.OnNextVideo;
            @NextVideo.canceled -= instance.OnNextVideo;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerMovementsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnTbag(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnTimeWarp(InputAction.CallbackContext context);
        void OnMouseCursor(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
    }
    public interface IAudioOptionsActions
    {
        void OnPlay(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnPrevious(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnVolumeUp(InputAction.CallbackContext context);
        void OnVolumeDown(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnShoworHideMenu(InputAction.CallbackContext context);
        void OnShoworHideCheatsMenu(InputAction.CallbackContext context);
        void OnSkipIntro(InputAction.CallbackContext context);
        void OnPreviousVideo(InputAction.CallbackContext context);
        void OnNextVideo(InputAction.CallbackContext context);
    }
}
