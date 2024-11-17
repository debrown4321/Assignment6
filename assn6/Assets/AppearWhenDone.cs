using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Locomotion;
using UnityEngine;

public class AppearWhenDone : MonoBehaviour
{
    public TeleportInteractable self;
    public ButtonCommands checker;

    // Start is called before the first frame update
    void Start()
    {
        this.self = GetComponent<TeleportInteractable>();
        this.self.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (checker.doorOpen)
        {
            this.self.enabled = true;
        }
    }
}
