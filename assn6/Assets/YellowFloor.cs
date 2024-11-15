using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretrigger : MonoBehaviour
{
    public int orderIndex; // The order of this panel in the rainbow sequence

    public delegate void PanelSteppedOn(int index);
    public static event PanelSteppedOn OnPanelStepped;
    public TMP_Text orderCurrent;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        orderCurrent.text = orderCurrent.text + "1";
        //score = score + letter;
        if (orderCurrent.text.Contains("012345"))
        {
            Destroy(door);
        }
    }
}
