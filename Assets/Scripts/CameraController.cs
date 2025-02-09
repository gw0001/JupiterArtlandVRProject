﻿/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 20/01/20
 * Last modified: 09/03/2020
 */

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * CameraController.cs
 * 
 * CAMERA CONTROLLER
 * 
 * Uses user mouse input to determine
 * the direction the user is looking.
 */
public class CameraController : MonoBehaviour
{
    // Mouse sensitivity - serialized for tweaking in Unity Editor
    [SerializeField]
    private float _mouseSensitivity = 5.0f;

    // Maximum and Minimum angles of rotation
    // Minium rotation angle in Y
    public float _minimumY = -90.0f;
    // Maximum rotation angle in Y
    public float _maximumY = 90.0f;
    // Note - Minimum and Maximum X values are only required when using mouse for camera control

    // Rotation Variables
    // Rotation in X
    private float _rotationX = 0.0f;
    // Rotation in Y
    private float _rotationY = 0.0f;

    // Camera component
    private Camera _theCamera;

    /*
     * AWAKE METHOD
     * 
     * Method is called when scene is awoken
     * 
     * Method obtains the camera component, locks the
     * mouse cursor to the middle of the screen,
     * and hides the mouse cursor from view.
     */
    void Awake()
    {
        // Lock the cursor to the window of the application
        Cursor.lockState = CursorLockMode.Locked;

        // Hide cursor from the main view
        Cursor.visible = false;

        // Determine the camera object that the script is assigned to
        _theCamera = Camera.main;
    }

    /*
     * UPDATE METHOD
     * 
     * Method is called before the first frame of the 
     * application has loaded
     */
    void Update()
    {
        // Determine the rotation in X from mouse input
        _rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _mouseSensitivity;

        // Determine the rotation in Y from the mouse input
        _rotationY += Input.GetAxis("Mouse Y") * _mouseSensitivity;

        // Use clamp method to determine the value for the Y Rotation
        _rotationY = Mathf.Clamp(_rotationY, _minimumY, _maximumY);

        // Transform the camera rotation
        _theCamera.transform.localEulerAngles = new Vector3(-_rotationY, _rotationX, 0);
    }
}