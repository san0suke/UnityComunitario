using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CenaInicialController : MonoBehaviour
{
    internal PlayerControls playerControls;

    private void Start()
    {
        playerControls.PlayerMenuControls.Start.performed += context => StartPressed(context);
    }

    private void StartPressed(InputAction.CallbackContext context)
    {

    }

    private void OnEnable()
    {
        playerControls = new PlayerControls();
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
