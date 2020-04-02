/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Gregor Kelly
 * Date: 20/02/20
 * Last modified: 24/03/2020
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_1 : MonoBehaviour
{
    private Canvas CanvasObject;
    private bool PageUsed;
    // Start is called before the first frame update
    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        PageUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && PageUsed == false)
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            PageUsed = true;
        }
    }
}
