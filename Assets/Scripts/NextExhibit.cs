/*
 * JUPITER ARTLAND VR EXPERIENCE 
 *
 * Author(s): Fletcher Moore
 * Date: 20/02/2020
 * Date last modified: 23/02/2020
 */


//Libraries 
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * NextExhibit.cs 
 *
 * NextExhibit
 *
 * Script allows Navigation from Cells of Life to 
 * Separation In The Evening
 * 
 * Methods: Start(), Update()
 */
public class NextExhibit : MonoBehaviour
{
    //Variables
    //Camera component
    public Camera theCamera;


    /*
     * START METHOD
     *
     * Method is invoked before the first frame
     * of the scene
     * 
     * Method obtains the camera used in the scene
     */
    void Start()
    {
        //Obtains the Camera component
        theCamera = GetComponent<Camera>();
    }


    /*
     * UPDATE METHOD
     *
     * Method is invoked once per frame
     * 
     * Method moves the camera to the next exhibit depending
     * on where the user currently is and/or the user's input
     */
    void Update()
    {
        //Move to next exhibit pressing Key N
        if (Input.GetKeyDown(KeyCode.N))
        {
            //Loads scene - Separation in the Evening
            SceneManager.LoadScene("SeparationInTheEvening");
            //Sets Camera up for new scene
            theCamera.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}

