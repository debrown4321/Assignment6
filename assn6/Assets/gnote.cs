using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gnote : MonoBehaviour
{
    public TMP_Text scoreText;
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
        scoreText.text = scoreText.text + "G";
        //score = score + letter;
        if(scoreText.text.Contains("GGAGCB")){
            Destroy(door);
        }
    }
}
