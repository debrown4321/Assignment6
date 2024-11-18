using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    //keep track of hour hand rotation z value = 45
    ////keep track of minute hand rotation z value = 0
    ///if both -> destroy door
    public GameObject HourHand;
    //public GameObject MinuteHand;
    public GameObject door;
    private int ClockGrabCount;

    //private Vector3 targetHourRotation = new Vector3(0, 0, 56);
    //private float rotationThreshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //CheckWinCondition();
    }

    // Update is called once per frame
    void Update()
    {
        //CheckWinCondition();
    }

    void IncrementGrabCount()
    {
        ClockGrabCount++;
        Debug.Log("Clock grabbed:" + ClockGrabCount + "times");


        //if (ApproximatelyEqual(hourHandRotation, targetHourRotation))
        if (ClockGrabCount == 2) { 
            Destroy(door);
            Debug.Log("You Won!");
        }

    }

    //bool ApproximatelyEqual(Vector3 a, Vector3 b) {
    //    return Mathf.Abs(a.x - b.x) < rotationThreshold &&
    //        Mathf.Abs(a.y - b.y) < rotationThreshold &&
    //        Mathf.Abs(a.z - b.z) < rotationThreshold;
    //}
}
