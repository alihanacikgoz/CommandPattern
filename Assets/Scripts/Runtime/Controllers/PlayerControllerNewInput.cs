using System;
using Runtime.Singletons;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Runtime.Controllers
{
    public class PlayerControllerNewInput : MonoBehaviour
    {
        private Animator _animator;
        private InputActions _inputActions;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _inputActions = InputActionsSingleton.Instance.Controls();
        }

        private void OnEnable()
        {
            _inputActions.Character.Movement.performed += OnMove;
            _inputActions.Character.Jump.performed += OnJump;
            _inputActions.Character.Kick.performed += OnKick;
            _inputActions.Character.Punch.performed += OnPunch;
        }

        private void OnDisable()
        {
            _inputActions.Character.Movement.performed -= OnMove;
            _inputActions.Character.Jump.performed -= OnJump;
            _inputActions.Character.Kick.performed -= OnKick;
            _inputActions.Character.Punch.performed -= OnPunch;
        }

        private void OnPunch(InputAction.CallbackContext obj)
        {
            
        }

        private void OnKick(InputAction.CallbackContext obj)
        {
            
        }

        private void OnJump(InputAction.CallbackContext obj)
        {
            
        }

        private void OnMove(InputAction.CallbackContext obj)
        {
            
        }
    }
}
