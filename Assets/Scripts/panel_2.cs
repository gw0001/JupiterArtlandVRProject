using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_2 : MonoBehaviour
{
    private Canvas CanvasObject;
    private bool PageUsed;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        CanvasObject.enabled = !CanvasObject.enabled;
        PageUsed = false;
        count = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && PageUsed == true && count<2)
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            count = count + 1;
        }

        if (Input.GetKeyUp(KeyCode.Space) && PageUsed == false)
        {
            count = count + 1;
            CanvasObject.enabled = !CanvasObject.enabled;
            PageUsed = true;
        }        
    }
}
