using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puzzlesolved : MonoBehaviour
{
    // public string score;
    public TMP_Text scoreText;
    public GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //updateScore("A");
    }
    public void updateScore(string letter){
        scoreText.text = scoreText.text + letter;
        //score = score + letter;
        if(scoreText.text.Contains("GGAGCB")){
            Destroy(door);
        }
    }
}
