/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 08/03/20
 * Last modified: 09/03/2020
 */

 // Libraries
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

/*
 * InteractiveItem.cs
 * 
 * INTERACTIVE ITEM
 * 
 * Class that manages actions for an
 * interactive item based on user inputs
 */
public class InteractiveItem : MonoBehaviour
{
    // On Over action when user's gaze moves over the interactive item
    public event Action OnOver;

    // On Out action when user's gaze moves off the interactive item
    public event Action OnOut;

    // Is Over Boolean
    protected bool _isOver;

    /*
     * OVER METHOD
     * 
     * Called when user's gaze is over the
     * interactive item
     */
    public void Over()
    {
        // Set is over to true
        _isOver = true;

        // Check that OnOver action does not equal null
        if (OnOver != null)
        {
            // Invoke OnOver Action (button)
            OnOver();
        }
    }

    /*
     * OUT METHOD
     * 
     * Called when user's gaze is over the
     * interactive item
     */
    public void Out()
    {
        // Set is over to false
        _isOver = false;

        // Check that OnOut action does not equal null
        if (OnOut != null)
        {
            // Invoke OnOut Action (button)
            OnOut();
        }
    }
}
