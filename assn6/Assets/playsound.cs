using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(clip);
    }

    // Update is called once per frame
//     void Update()
//     {
//         source.PlayOneShot(clip);
//     }
}
