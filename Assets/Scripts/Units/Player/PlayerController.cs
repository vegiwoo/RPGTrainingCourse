using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace RPG.Units.Player
{
    public class PlayerController : MonoBehaviour
    {
        #region Variables and constants

        private PlayerControls inputs;
        private StatsAssistant statsAssistant;

        private Rigidbody rigidbody;
       
        private Vector3 movementDirection = Vector3.zero;
      

        #endregion

        #region MonoBehaviour methods

        private void Awake()
        {
            inputs = new PlayerControls();
        }

        private void Update()
        {
            if (movementDirection != Vector3.zero)
            {
                transform.position += movementDirection * statsAssistant.GetHeroMoveSpeed() * Time.deltaTime;
            }
        }

        private void OnEnable()
        {
            inputs.Enable();
            inputs.GameMap.Movement.performed += OnMovementHero;
            inputs.GameMap.Movement.canceled += OnMovementHero;
            inputs.GameMap.FastAttack.performed += OnFastAttackHero;
            inputs.GameMap.StrongAttack.performed += OnStrongAttackHero;
        }

        private void OnDisable()
        {
            inputs.GameMap.Movement.performed -= OnMovementHero;
            inputs.GameMap.FastAttack.performed -= OnFastAttackHero;
            inputs.GameMap.StrongAttack.performed -= OnStrongAttackHero;
            inputs.Disable();
        }

        private void OnDestroy()
        {
            inputs.Dispose();
        }

        #endregion

        #region Event handlers

        public void OnMovementHero(CallbackContext context)
        {
            switch (context.phase)
            {
                case UnityEngine.InputSystem.InputActionPhase.Performed:
                    Vector2 dir = context.ReadValue<Vector2>();
                    movementDirection = new Vector3(dir.x, 0, dir.y);
                    break;
                case UnityEngine.InputSystem.InputActionPhase.Canceled:
                    movementDirection = Vector3.zero;
                    break;
                default:
                    break;
            }
        }

        public void OnFastAttackHero(CallbackContext context)
        {
            print("Fast Attack!");
        }

        public void OnStrongAttackHero(CallbackContext context)
        {
            print("Strong Attack!");
        }

        #endregion
    }
}