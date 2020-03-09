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
using UnityEngine;

/*
 * CrossHair.cs
 * 
 * CROSS HAIR
 * 
 * Class that manages the rotation
 * and scale of the user's cross hair
 */
public class CrossHair : MonoBehaviour
{
    // Cross Hair Transformation
    [SerializeField]
    private Transform _crossHairTransform;

    // The Camera
    [SerializeField]
    private Transform _theCamera;

    // Original Scale Vector
    private Vector3 _origScale;

    // Original Rotation Quaternion
    private Quaternion _origRotation;

    /*
     * AWAKE METHOD
     * 
     * Method invoked when scene is "awoken"
     * 
     * When awoken, obtains the original
     * scale and rotation of the cross hair
     */
    private void Awake()
    {
        // Store orignal scale
        _origScale = _crossHairTransform.localScale;

        // Store original rotation
        _origRotation = _crossHairTransform.localRotation;
    }

    /*
     * SET POSITION METHOD
     * 
     * Overloaded method
     * 
     * Sets the position of the cross hair when
     * the gaze ray hasn't collided with an 
     * interactive
     */
    public void SetPosition()
    {
        // Set the position of the cross hair
        _crossHairTransform.position = _theCamera.position + _theCamera.forward;

        // Set the scale of the cross hair
        _crossHairTransform.localScale = _origScale;

        // Set the rotation of the cross hair
        _crossHairTransform.localRotation = _origRotation;
    }

    /*
     * SET POSITION METHOD
     * 
     * Overloaded method
     * 
     * Sets the position of the cross hair when
     * the gaze ray has collided with an 
     * interactive.
     * 
     * Method takes a raycast collision as an
     * argument
     */
    public void SetPosition(RaycastHit aCollision)
    {
        // Set the position of the cross hair based on the collision point
        _crossHairTransform.position = aCollision.point;

        // Set the scale of the cross hair based on the collision point
        _crossHairTransform.localScale = _origScale * aCollision.distance;

        // Set the rotation of the cross hair
        _crossHairTransform.localRotation = _origRotation;
    }
}
