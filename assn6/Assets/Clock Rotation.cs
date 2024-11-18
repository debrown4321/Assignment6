using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotation : MonoBehaviour

{
    public Transform clockHand;
    public GameObject door;
    private int ClockGrabCount = 0;
    private bool isTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        RotateHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotateHand()
    {
        clockHand.Rotate(0, 0, 28f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered)
        {
            Debug.Log("TRIGGERED");
            isTriggered = true;
            RotateHand();
            IncrementGrabCount();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggered = false;
    }

    void IncrementGrabCount()
    {
        ClockGrabCount++;
        Debug.Log("Hour Hand Pressed " + ClockGrabCount + " times");

        if (ClockGrabCount == 3)
        {
            Destroy(door);
            Debug.Log("You won");
        }
    }
}
