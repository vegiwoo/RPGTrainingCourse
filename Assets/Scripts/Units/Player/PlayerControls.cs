// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Units/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace RPG.Units.Player
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameMap"",
            ""id"": ""2064264d-5e13-456a-841f-f489a4fc9f12"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2437b492-2ecb-461a-a700-4a1ec91208a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""12b2b217-b79d-4b3b-87fd-33ff172da581"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""cc2762cf-3421-4e1b-9f8c-609799d5b4c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d6077807-ba07-4134-8203-5b97339223ef"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1092f32c-c50e-48d6-a1cf-cc83f03c5df3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""21aa8d58-663c-41e1-a723-ae7eabc165c4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""343e00cd-4d39-48de-8dc1-455c54b15e29"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7f5c6bcb-38f7-470b-a3d5-899e76d32852"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""68273176-719c-44cb-a816-9a0c1b30a22e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b7224d61-f9f9-4ae0-bbcf-7ecb8c8eb926"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b08c9ce0-da2e-4934-bc06-65ccb54cd761"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""719f720a-476b-4abb-b899-35b5fc061735"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7fee89da-4a3c-4ff4-9077-2d8c3e357395"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""79cf924e-c42d-4363-ac19-921ab98c9383"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2a0d2ad-cc0e-4ae2-90f1-a11bcc73dd3d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GameMap
            m_GameMap = asset.FindActionMap("GameMap", throwIfNotFound: true);
            m_GameMap_Movement = m_GameMap.FindAction("Movement", throwIfNotFound: true);
            m_GameMap_FastAttack = m_GameMap.FindAction("FastAttack", throwIfNotFound: true);
            m_GameMap_StrongAttack = m_GameMap.FindAction("StrongAttack", throwIfNotFound: true);
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

        // GameMap
        private readonly InputActionMap m_GameMap;
        private IGameMapActions m_GameMapActionsCallbackInterface;
        private readonly InputAction m_GameMap_Movement;
        private readonly InputAction m_GameMap_FastAttack;
        private readonly InputAction m_GameMap_StrongAttack;
        public struct GameMapActions
        {
            private @PlayerControls m_Wrapper;
            public GameMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_GameMap_Movement;
            public InputAction @FastAttack => m_Wrapper.m_GameMap_FastAttack;
            public InputAction @StrongAttack => m_Wrapper.m_GameMap_StrongAttack;
            public InputActionMap Get() { return m_Wrapper.m_GameMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameMapActions instance)
            {
                if (m_Wrapper.m_GameMapActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnMovement;
                    @FastAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @FastAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnFastAttack;
                    @StrongAttack.started -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.performed -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.canceled -= m_Wrapper.m_GameMapActionsCallbackInterface.OnStrongAttack;
                }
                m_Wrapper.m_GameMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @FastAttack.started += instance.OnFastAttack;
                    @FastAttack.performed += instance.OnFastAttack;
                    @FastAttack.canceled += instance.OnFastAttack;
                    @StrongAttack.started += instance.OnStrongAttack;
                    @StrongAttack.performed += instance.OnStrongAttack;
                    @StrongAttack.canceled += instance.OnStrongAttack;
                }
            }
        }
        public GameMapActions @GameMap => new GameMapActions(this);
        public interface IGameMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnFastAttack(InputAction.CallbackContext context);
            void OnStrongAttack(InputAction.CallbackContext context);
        }
    }
}
