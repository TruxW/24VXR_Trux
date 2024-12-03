using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererComponent : MonoBehaviour
{

    private Renderer objectRenderer;
    // Start is called before the first frame update
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            objectRenderer.material.color = Color.green;
        }
    }
}
