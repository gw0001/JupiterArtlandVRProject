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
using UnityEngine.UI;

// Component Reqruirements for class
// Interactive Item component requirement
[RequireComponent(typeof(InteractiveItem))]
// Box Collider component requirement
[RequireComponent(typeof(BoxCollider))]

/*
 * HotspotGaze.cs
 * 
 * HOTSPOT BUTTON GAZE
 * 
 * Class for determining how a hot spot
 * reacts to a user's gaze.
 */
public class HotspotGaze : MonoBehaviour
{
    // Hot Spot object
    private Button _hotSpot;
    
    // Is Over Boolean
    private bool _isOver = false;

    // Interactive object activated by user's gaze
    private InteractiveItem _interactiveItem;

    // Using Fill Image Boolean
    public bool _useFillImage = true;

    // Cross Hair Fill Image
    [SerializeField] private Image _crossHairFillImage;

    // Hide On Start boolean
    [SerializeField] private bool _hideOnStart = true;

    // Time to wait before selection confirmed by user
    public float selectionTime = 2.0f; 

    // Coroutine for starting and stopping of the fill image
    private Coroutine _selectionFill;

    // Cross Hair Filled Boolean
    private bool _crossHairFilled;

    // Selection Cross Hair Active Boolean
    private bool _selectionCrossHairActive;

    /*
     * AWAKE METHOD
     * 
     * Method is invoked when script is "awoken"
     * 
     * When invoked, the method obtains the hotspot
     * object and the Interactive Object applied
     * to the hot spot (2D UI Button)
     */
    private void Awake()
    {
        // Obtain Hot Spot Component
        _hotSpot = GetComponent<Button>();
        
        // Obtain Interactive Item Component
        _interactiveItem = GetComponent<InteractiveItem>();
    }

    /*
     * START METHOD
     * 
     * Method is invoked before the first frame
     * 
     * When invoked, the method initialises the
     * cross hair fill image amount to 0 
     * (nothing selected), and hides cross hair
     * if told to hide on start
     */
    private void Start()
    {
        // Set Cross Hair Fill amount to 0
        _crossHairFillImage.fillAmount = 0.0f;

        // Check if it should be hidden on start
        if (_hideOnStart == true)
        {
            // Hide cross hair fill image
            Hide();
        }
    }

    /*
     * HIDE METHOD
     * 
     * Method hides the cross hair fill image
     */
    public void Hide()
    {
        // Set Cross Hair Fill Image as not active
        _crossHairFillImage.gameObject.SetActive(false);

        // Set Selection Cross Hair Active to false
        _selectionCrossHairActive = false;

        // Set Fill amount to 0
        _crossHairFillImage.fillAmount = 0.0f;
    }

    /*
     * SHOW METHOD
     * 
     * Method shows the cross hair fill image
     */
    public void Show()
    {
        // Set cross hair fill image as active
        _crossHairFillImage.gameObject.SetActive(true);

        // Set Selection cross hair boolean as active
        _selectionCrossHairActive = true;
    }

    /*
     * ON ENABLE METHOD
     * 
     * Method for enabled hotspot
     */
    private void OnEnable()
    {
        // Determine cross hair fill if users gaze is over a hotspot
        _interactiveItem.OnOver += HandleOver;

        // Determine cross hair fill if users gaze not over a hotspot
        _interactiveItem.OnOut += HandleOut;
    }

    /*
     * FILL SELECTION CROSS HAIR
     * 
     * Method for filling the cross hair fill
     * image 
     */
    private IEnumerator FillSelectionCrossHair()
    {
        // Set cross hair filled boolean to false
        _crossHairFilled = false;

        // Show the cross hair fill image
        Show();

        // Timer
        float timer = 0.0f;

        // Set Cross hair fill image to 0
        _crossHairFillImage.fillAmount = 0.0f;

        // Loop while timer is less than the selection time
        while (timer < selectionTime)
        {
            // Determine the fill value (Must be a number between 0 and 1)
            float fill = timer / selectionTime;

            // Set fill amount of the fill image
            _crossHairFillImage.fillAmount = fill;

            // Increment timer by time increment (delta time)
            timer += Time.deltaTime;

            // Yield return null required to return value back for method
            yield return null;
        }

        // Set fill amount to 1 (full)
        _crossHairFillImage.fillAmount = 1.0f;

        // Set Selection Cross Hair Active to false
        _selectionCrossHairActive = false;

        // Set cross hair filled boolean to true
        _crossHairFilled = true;

        // Invoke selected hot spot
        _hotSpot.onClick.Invoke();

        // Hide cross hair fill image
        Hide();
    }

    /*
     * HANDLE OVER METHOD
     * 
     * Method for when the user gazes 
     * over a hotspot
     */
    private void HandleOver()
    {
        // Set is over to true
        _isOver = true;

        // Send message to Unity Editor to show co-routine is carrying out fill
        Debug.Log("Start Fill Coroutine");

        // Start coroutine for selection fill
        _selectionFill = StartCoroutine(FillSelectionCrossHair());
    }

    /*
     * HANDLE OUT METHOD
     * 
     * Method for when the user's gaze 
     * is not on a hot spot
     */
    private void HandleOut()
    {
        // Set is over to false
        _isOver = false;

        // Check if selection fill does not equal null
        if (_selectionFill != null)
        {
            // Send message to Unity Editor to show co-routine has stopped
            Debug.Log("Stop Fill Coroutine");

            // Stop the selection fill coroutine
            StopCoroutine(_selectionFill);
        }

        // Set selection fill image amount to 0.0f
        _crossHairFillImage.fillAmount = 0.0f;
    }
}