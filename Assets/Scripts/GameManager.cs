/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 17/02/2020
 * Last modified: 17/02/2020
 */

 // Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * GameManager.cs
 * 
 * GAME MANAGER
 * 
 * Incomplete script...
 */
public class GameManager : MonoBehaviour
{
    // Array of Hot Spot Coordinate vectors
    public Vector3[] hotspotCoords = new Vector3[20];

    // Camera component
    private Camera _theCamera;


    // Start is called before the first frame update
    void Start()
    {
        _theCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
