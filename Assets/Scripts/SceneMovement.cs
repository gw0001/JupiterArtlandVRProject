/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 04/03/2020
 * Last modified: 04/03/2020
 */

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * SceneMovement.cs
 * 
 * SCENE MOVEMENT
 * 
 * Script created to allow a user to change scene
 * when the user presses a button (1 - 0, U, I, O, P)
 * 
 * Based on CameraMovement.cs script
 * 
 * FOR DEVELOPMENT PURPOSES ONLY 
 */
public class SceneMovement : MonoBehaviour
{
    // Game Manager game object
    public GameManager theGM;

    /*
     * AWAKE METHOD
     * 
     * Method is invoked before when the scene
     * is loaded
     * 
     * Method obtains the game manager and
     * checks for user input at each frame.
     * 
     */
    private void Awake()
    {
        // Obtain the game manager component
        theGM = GetComponent<GameManager>();
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
            theGM.sceneSelection(theGM.scenesToLoad[0]);
        }

        // User presses 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[1]);
        }

        // User presses 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[2]);

        }

        // User presses 4
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[3]);

        }

        // User presses 5
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[4]);
        }

        // User presses 6
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[5]);

        }

        // User presses 7
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[6]);

        }

        // User presses 8
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[7]);

        }

        // User presses 9
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[8]);

        }

        // User presses 0
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[9]);

        }

        // User presses U
        if (Input.GetKeyDown(KeyCode.U))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[10]);
        }

        // User presses I
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[11]);
        }

        // User presses O
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[12]);
        }

        // User presses P
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Change camera to new position
            theGM.sceneSelection(theGM.scenesToLoad[13]);
        }
    }
}
