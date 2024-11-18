using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void OnButtonPress()
    { // Change the color to a random color
      meshRenderer.material.color = Random.ColorHSV();
    }
}
