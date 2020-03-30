using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToogleHub : MonoBehaviour
{
    private string messageText="If you are reading this... good";
    public GameObject MakeVisable, makeInvisable;

    private void Start()
    {
        MakeVisable.GetComponent<GameObject>();
        makeInvisable.GetComponent<GameObject>();
    }

    
    void Update()
    {
        bool o = Input.GetKeyDown(KeyCode.O);
        bool p = Input.GetKeyDown(KeyCode.P);
        // User presses 1
        if (o)
        {
            makeInvisable.SetActive(false);
            MakeVisable.SetActive(true);
            Debug.Log(messageText);
        }
        // User presses 1
        if (p)
        {
            makeInvisable.SetActive(true);
            MakeVisable.SetActive(false);
            Debug.Log(messageText);
        }
    }
    
}
