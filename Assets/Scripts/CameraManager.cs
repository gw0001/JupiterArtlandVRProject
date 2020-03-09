using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject m_cameraUI;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    private void Update()
    {
        checkForOtherCameras();
    }


    private void checkForOtherCameras()
    {
        if(Camera.allCamerasCount > 1)
        {
            foreach (Camera c in Camera.allCameras)
            {
                if(c.gameObject.CompareTag("MainCamera") == false)
                {
                    c.gameObject.SetActive(false);
                }
            }
        }
    }

    public void turnOnUI()
    {
        if(m_cameraUI == true)
        {
            m_cameraUI.SetActive(true);
        }
    }

    public void turnOffUI()
    {
        if (m_cameraUI == true)
        {
            m_cameraUI.SetActive(false);
        }
    }

}
