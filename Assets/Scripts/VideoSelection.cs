/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 14/02/2020
 * Last modified: 15/02/2020
 */

//Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * VideoSelection.cs
 * 
 * VIDEO SELECTION
 * 
 * Script allows for user input to change
 * the video displayed on the skybox
 */
public class VideoSelection : MonoBehaviour
{

    public VideoPlayerManager vidPlayerManager;


    // Start is called before the first frame update
    void Start()
    {
        vidPlayerManager.GetComponent<VideoPlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // User presses 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Play video in element 0 (video 1)
            vidPlayerManager.PlayVideo(0);
        }

        // User presses 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Play video in element 1 (video 2)
            vidPlayerManager.PlayVideo(1);
        }


        // User presses 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Play video in element 2 (video 3)
            vidPlayerManager.PlayVideo(2);
        }

        // User presses 4
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Play video in element 3 (video 4)
            vidPlayerManager.PlayVideo(3);
        }

        // User presses 5
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Play video in element 4 (video 5)
            vidPlayerManager.PlayVideo(4);
        }

        // User presses 6
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // Play video in element 5 (video 6)
            vidPlayerManager.PlayVideo(5);
        }

        // User presses 7
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // Play video in element 6 (video 7)
            vidPlayerManager.PlayVideo(6);
        }

        // User presses 8
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // Play video in element 7 (video 8)
            vidPlayerManager.PlayVideo(7);
        }

        // User presses 9
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            // Play video in element 8 (video 9)
            vidPlayerManager.PlayVideo(8);
        }

        // User presses 0
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // Play video in element 9 (video 10)
            vidPlayerManager.PlayVideo(9);
        }

        // User presses I
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Play video in element 10 (video 11)
            vidPlayerManager.PlayVideo(10);
        }

        // User presses O
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Play video in element 11 (video 12)
            vidPlayerManager.PlayVideo(11);
        }

        // User presses P
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Play video in element 12 (video 13)
            vidPlayerManager.PlayVideo(12);
        }
    }
}
