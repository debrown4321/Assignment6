using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    private Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();

    }

    public void OnPoke()
    {
        // Change the color of the cube to a random color
        cubeRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
