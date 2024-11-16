using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Orange_floor : MonoBehaviour
{
    // Start is called before the first frame update
    public int orderIndex; // The order of this panel in the rainbow sequence

    public TMP_Text orderCurrent;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        print(orderCurrent);
    }

    // Update is called once per frame
    void Update()
    {
        if (orderCurrent.text.Contains("012345"))
        {
            Destroy(door);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        orderCurrent.text = orderCurrent.text + "5";
        //score = score + letter;
        if (orderCurrent.text.Contains("012345"))
        {
            Destroy(door);
        }
    }
}
