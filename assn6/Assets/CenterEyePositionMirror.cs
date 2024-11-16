using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterEyePositionMirror : MonoBehaviour
{
    [SerializeField] private Transform centerEyeTransform;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = centerEyeTransform.localPosition;
    }
}
