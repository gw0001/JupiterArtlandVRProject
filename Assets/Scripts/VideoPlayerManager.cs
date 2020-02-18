/*
 * JUPITER ARTLAND VR EXPERIENCE
 * 
 * Author: Graeme White
 * Date: 14/02/2020
 * Last modified: 16/02/2020
 */

//Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

// Required components
// Component of VideoPlayer type
[RequireComponent(typeof(VideoPlayer))]

/*
 * VideoPlayerManager.cs
 * 
 * VIDEO PLAYER MANAGER
 * 
 * Script that allows the video player 
 * component to play videos held in 
 * an array
 */
public class VideoPlayerManager : MonoBehaviour
{
    // Array of video clips - set to 16 by default, but can be changed in the Unity editor
    public VideoClip[] videos = new VideoClip[16];

    // Video player component
    [SerializeField]
    private VideoPlayer _videoPlayer;

    /*
     * START METHOD
     * 
     * Method is invoked before the first frame
     * 
     * Once invoked, obtains the video player component
     */
    void Start()
    {
        // Obtain video player component from the scene
        _videoPlayer = gameObject.GetComponent<VideoPlayer>();
    }

    /*
     * PLAY VIDEO
     * 
     * Method used to play video held at a specific
     * index in the video array.
     * 
     * Method checks that the index number is not too
     * big or too small for the array.
     * 
     * Once checked, the method fetches the video held
     * at the index number of the array and plays it.
     */
    public void PlayVideo(int indexNumber)
    {

        // Determine if the element number is greater than the number of videos in the array
        if (indexNumber >= videos.Length)
        {
            // Send error message to the developer console
            Debug.LogErrorFormat("Error! Cannot play video at ID: {0}. The array of videos contains {1} video(s)", indexNumber, videos.Length);
            
            // Return out of the method
            return;
        }
        // Determine if the element number is smaller than zero
        else if(indexNumber < 0)
        {
            // Send error message to the developer console
            Debug.LogErrorFormat("Error! The index number entered ({0}) is smaller than 0! The smallest index number must be 0!", indexNumber);

            // Return out of the method
            return;
        }

        // Obtain the video held in the array at the requested element number
        _videoPlayer.clip = videos[indexNumber];

        // Play the video
        _videoPlayer.Play();
    }
}



