/*
 * JUPITER ARTLAND VR EXPERIENCE  
 *
 * Author(s): Fletcher Moore
 * Date: 22/02/2020
 * Date last modified: 23/02/2020
 */

 //Libraries 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * SceneSelection1.cs
 *
 * SceneSelection1
 *
 * This class allows for the user to select a "hotspot" 
 * on the MainMap in order to move to the selected
 * exhibit, therefore moving to another scene
 * 
 * Methods: 
 */
public class SceneSelection1 : MonoBehaviour
{
    //Variables
    //Image
    public Image timerSphere;
    //Total time for timer
    public float totalTime = 2;
    //GVR status
    public bool status;
    //GVR timer
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
    * UPDATE METHOD
    *
    * 
    */
    void Update()
    {
        if (status)
        {
            //sets time 
            timer += Time.deltaTime;
            //fills timerSphere depending on timer
            timerSphere.fillAmount = timer / totalTime;
        }
    }

    /*
     * GVRON METHOD
     *
     * Activates the Timer
     */
    public void GVROn()
    {
        status = true;
    }

    /*
    * GVROFF METHOD
    *
    * Deactivates the Timer
    */
    public void GVROff()
    {
        status = false;
        //Retruns timer to 0
        timer = 0;
        //returns the fill of the sphere to 0 
        timerSphere.fillAmount = 0;
    }
}
