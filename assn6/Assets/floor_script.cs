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
        if (orderCurrent.text.Length == 0 || orderCurrent.text[orderCurrent.text.Length - 1] != orderIndex.ToString()[0])
        {
            orderCurrent.text = orderCurrent.text + orderIndex.ToString();
        }
        //score = score + letter;
        if (orderCurrent.text.Contains("012345"))
        {
            Destroy(door);
        }
    }
}
