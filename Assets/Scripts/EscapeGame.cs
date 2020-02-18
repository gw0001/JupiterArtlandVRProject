/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 20/01/20
 * Last modified: 20/02/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * EscapeGame.cs
 * 
 * Simple script that allows a user
 * to escape the application when using
 * on PC.
 * 
 * FOR DEVELOPMENT PUROSES ONLY
 */
public class EscapeGame : MonoBehaviour
{
    /*
     * START METHOD
     * 
     * Method is called before the first frame of the 
     * application has loaded
     */
    void Start()
    {
        
    }

    /*
     * UPDATE METHOD
     * 
     * Method is called once per frame.
     * 
     * Method checks to see if user has pressed the "Escape"
     * key.
     */
    void Update()
    {
        // User presses the key to quit (Esc key by default)
        if(Input.GetKeyDown("escape"))
        {
            // Application quits
            Application.Quit();
        }
    }
}
