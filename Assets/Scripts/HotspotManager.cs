/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 08/03/20
 * Last modified: 08/03/2020
 */

// Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * HotspotManager.cs
 * 
 * HOTSPOT MANAGER
 * 
 * Class that manages the linking of hotspots
 * in a scene and the scenes that they are
 * required to load
 */
public class HotspotManager : MonoBehaviour
{
    // Array of the hotspots in the scene
    public Button[] _hotspotsInScene;
    
    // Game Manager for the scene - field serialized to appear in the Unity Engine Editor
    [SerializeField]
    private GameManager theGM;

    /*
     * START METHOD
     * 
     * Method is called before the first frame of the 
     * application has loaded.
     * 
     * When called, the method invokes the Link Hotspots
     * to Scenes method
     */
    void Start()
    {
        // Invoke the Link Hotspots to Scenes method
        linkHotspotsToScenes();
    }

    /*
     * LINK HOTSPOTS TO SCENE METHOD
     * 
     * When invoked, the method will first check to see if
     * the number of buttons in a scene match the number
     * of scenes to load contained within the game manager.
     * 
     * If the number of buttons do not match the number of 
     * scenes, an error message is thrown to the Unity 
     * Engine Editor.
     * 
     * If the number of buttons matches the number of scenes,
     * the buttons are linked to the scenes, based on the index
     * number of both arrays
     * 
     * e.g. The hotspot in element 0 of the hotspot manager is
     * linked to the scene 
     */
    public void linkHotspotsToScenes()
    {
        // Check if the number of hotspots in scene match the number of scenes to load
        if(_hotspotsInScene.Length != theGM.scenesToLoad.Length)
        {
            // Send error message to editor, as the number of hotspots in the scene do not match the number of scenes to load
            Debug.Log("Uh oh! The number of hotspots in the scene do not match the number of scenes to load. Sort it out!");

            // Break loop
            return;
        }
        // Number of buttons match the number of scenes to load
        else
        {
            // Iterate over all index values
            for (int i = 0; i < _hotspotsInScene.Length; i++)
            {
                // Obtain scene name from the game manager
                string sceneName = theGM.scenesToLoad[i];

                // Link the hotspot at element i of the hotspot array to the scene at element i of the game manager array
                _hotspotsInScene[i].onClick.AddListener(() => theGM.sceneSelection(sceneName));
            }
        }
    }
}
