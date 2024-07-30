using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeyColour : MonoBehaviour
{
    private void Start()
    {
        // Create a new cube primitive to set the color on
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Get the Renderer component from the new cube
        var playerRenderer = Player.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to red
        playerRenderer.material.SetColor("_Color", Color.red);

    }

}
