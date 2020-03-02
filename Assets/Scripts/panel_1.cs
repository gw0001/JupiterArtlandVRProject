using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_1 : MonoBehaviour
{
    private Canvas CanvasObject; // Assign in inspector
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
