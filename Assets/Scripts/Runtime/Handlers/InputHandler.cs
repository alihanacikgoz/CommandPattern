using System;
using Runtime.Singletons;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    #region Singleton

    public static InputHandler Instance { get; private set; }

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

    public GameObject actor;
    
    private Animator _animator;
    private Command jumpCommand, punchCommand, kickCommand, moveCommand;

    private void OnEnable()
    {
        InputActionsSingleton.Instance.Controls().Character.Jump.performed += Jump;
    }

    private void Jump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jumped");
        jumpCommand.Execute(_animator);
    }

    private void Start()
    {
        _animator = actor.GetComponent<Animator>();

        jumpCommand = new PerformJump();
    }
    
}