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
 * CameraUI.cs
 * 
 * CAMERA UI CLASS
 * 
 * Class for managing the UI of the
 * camera
 */
public class CameraUI : MonoBehaviour
{
    // UI Canvas object
    [SerializeField]
    private Canvas _canvas;

    /*
     * AWAKE METHOD
     * 
     * Method is invoked when scene is woken up
     * 
     * Method enables the UI, sets it to the 
     * highest layer, and forces the UI to
     * update
     */
    private void Awake()
    {
        // Enable UI
        _canvas.enabled = true;

        // Set UI to highest Layer level
        _canvas.sortingOrder = Int16.MaxValue;

        // Force UI Update
        Canvas.ForceUpdateCanvases();
    }
}
