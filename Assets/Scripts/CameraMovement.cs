/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 14/02/2020
 * Last modified: 17/02/2020
 */

 // Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * CameraMovement.cs
 * 
 * CAMERA MOVEMENT
 * 
 * Script created to test the movement of the camera
 * when the user presses a button (1 - 0, I, O, P)
 * 
 * FOR DEVELOPMENT PURPOSES ONLY 
 */
public class CameraMovement : MonoBehaviour
{
    // Camera component
    public Camera theCamera;

    /*
     * START METHOD
     * 
     * Method is invoked before the first frame
     * of the scene.
     * 
     * Method obtains the camera used in the scene
     */
    void Start()
    {
        // Obtain the camera component
        theCamera = GetComponent<Camera>();
    }

    /*
     * UPDATE METHOD
     * 
     * Method is invoked once per frame
     * 
     * Method checks for user input, then moves
     * camera depending on the input
     */
    void Update()
    {
        // User presses 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }

        // User presses 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(20.0f, 0.0f, 25.0f);
        }

        // User presses 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(17.0f, 0.0f, 39.0f);
        }

        // User presses 4
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(14.0f, 0.0f, 52.0f);
        }

        // User presses 5
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(0.0f, 0.0f, -10.0f);
        }

        // User presses 6
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(100.0f, 0.0f, 100.0f);
        }

        // User presses 7
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(-251.0f, 0.0f, 300.0f);
        }

        // User presses 8
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(79.0f, 0.0f, 4.0f);
        }

        // User presses 9
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(-10.0f, 0.0f, -101.0f);
        }

        // User presses 0
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(10.0f, 0.0f, 10.0f);
        }

        // User presses I
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(0.0f, 20.0f, 0.0f);
        }

        // User presses O
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }

        // User presses P
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Change camera to new position
            theCamera.transform.position = new Vector3(25.0f, -25.0f, 25.0f);
        }
    }
}
