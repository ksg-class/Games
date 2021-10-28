using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public Controlol playerControl;
    private void Start()
    {
        playerControl = new Controlol();

        
        playerControl.Userlol.Jump.performed += obj =>Jump();
        //playerControl.Userlol.Jump.performed += Jump;
        //Another way to write the same thing

        playerControl.Userlol.Jump.Enable();

    }

    private void Jump()
    {
        Debug.Log("Jump pressed");
    }
   /* void Jump(InputAction.CallbackContext obj)
    {
        Debug.Log("Yolo jump")
    }*/
}
