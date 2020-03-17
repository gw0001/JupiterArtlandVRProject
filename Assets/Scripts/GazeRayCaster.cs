/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 08/03/20
 * Last modified: 18/03/2020
 */

// Libraries
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

/*
 * GazeRayCaster.cs
 * 
 * GAZE RAYCASTER
 * 
 * Class for allowing user's gaze to act as an 
 * input for activating interactive items
 */
public class GazeRayCaster : MonoBehaviour
{
    // Event for when the ray cast has collided with an interactive item
    public event Action<RaycastHit> rayCastHit;

    // Camera transformations
    [SerializeField]
    private Transform _theCamera;
    
    // Cross hair (User's gaze)
    [SerializeField]
    private CrossHair _crossHair;

    // Length of ray - set to 500.0f by default
    [SerializeField]
    private float _rayLength = 500.0f;

    // Current Interactive Item
    public InteractiveItem _currentInteractiveItem;

    // Previous Interactive Item
    private InteractiveItem _lastInteractiveItem;

    /*
     * FIXED UPDATE METHOD
     * 
     * Method is invoked in time with Unity's
     * Physics modules.
     * 
     * Method invokes ray casting at every update.
     * 
     * Using FixedUpdate instead of update avoids
     * issues when using on Android/iOS
     */
    private void FixedUpdate()
    {
        // Invoke ray casting from users perspective
        EyeRaycasting();
    }

    /*
     * EYE RAYCASTING METHOD
     * 
     * Method for casting a ray from the user's 
     * perspective
     */
    private void EyeRaycasting()
    {
        // Create a ray from user's perspective
        Ray ray = new Ray(_theCamera.position, _theCamera.forward);

        // Raycast hit object
        RaycastHit aCollision;

        // Check if ray collides with interactive item
        if (Physics.Raycast(ray, out aCollision, _rayLength))
        {
            // Obtain Interactive Item based on collision and store in Temporary Interactive Item object
            InteractiveItem tempInteractiveItem = aCollision.collider.GetComponent<InteractiveItem>();

            // Set Current Interactive Item
            _currentInteractiveItem = tempInteractiveItem;

            // Check that temporary interactive item exits and check that it is not the last interactive item
            if ((tempInteractiveItem == true) && (tempInteractiveItem != _lastInteractiveItem))
            {
                // Call over function for interactive item
                tempInteractiveItem.Over();
            }

            // Check if the temporary interactive item is not the same as the last interactive item
            if (tempInteractiveItem != _lastInteractiveItem)
            {
                // Invoke method to deactivate the last interactive item
                DeactiveLastInteractiveItem();
            }

            // Set last 
            _lastInteractiveItem = tempInteractiveItem;

            // Set position of cross hair to the ray cast hit
            _crossHair.SetPosition(aCollision);

            // Check if a ray cast hit exists
            if (rayCastHit != null)
            {
                // Set the ray cast hit to the collision
                rayCastHit(aCollision);
            }
        }
        // No hit detected
        else
        {
            // Nothing was hit, deactive the last interactive item.
            DeactiveLastInteractiveItem();

            // Set current interactive item to null
            _currentInteractiveItem = null;

            // Set the Cross Hair position
            _crossHair.SetPosition();
        }
    }

    /*
     * DEACTIVATE LAST INTERACTIVE ITEM
     * 
     * Method deactivates the previous interactive item
     * when invoked.
     */
    private void DeactiveLastInteractiveItem()
    {
        // Check if last interactive item doesn't exist
        if (_lastInteractiveItem == null)
        {
            // No previous interactive item exits, return
            return;
        }

        // Inoke Out method for last interactive item
        _lastInteractiveItem.Out();

        // Set last interactive item to null
        _lastInteractiveItem = null;
    }
}