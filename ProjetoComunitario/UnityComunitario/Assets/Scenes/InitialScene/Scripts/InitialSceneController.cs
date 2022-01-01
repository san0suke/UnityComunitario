using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InitialSceneController : MonoBehaviour
{
    internal PlayerControls playerControls;

    private void Start()
    {
        playerControls.PlayerMenuControls.Start.performed += context => StartPressed(context);
    }

    private void StartPressed(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
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
