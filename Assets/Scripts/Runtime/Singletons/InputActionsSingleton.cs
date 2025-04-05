using System;
using UnityEngine;

namespace Runtime.Singletons
{
    public class InputActionsSingleton : MonoBehaviour
    {
        #region Singleton
        public static InputActionsSingleton Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }
        #endregion
        
        #region Self Variables
        private InputActions _inputActions;
        #endregion


        public InputActions Controls()
        {
            return _inputActions;
        }
        
        
        

        private void OnEnable()
        {
            _inputActions = new InputActions();
            _inputActions.Enable();
        }

        private void OnDisable()
        {
            _inputActions.Disable();
        }
    }
}
