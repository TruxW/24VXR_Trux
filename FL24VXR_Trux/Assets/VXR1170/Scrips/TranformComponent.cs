using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TranformComponent : MonoBehaviour
{

    public Transform target;


    // Start is called before the first frame update
    void Update()
    {
        MoveCube();

        RotateCube();

        ScaleCube();

  

    }
    private void MoveCube()
    {
        float moveSpeed = 5f;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }


    }
    private void ScaleCube()
    {
        Vector3 scaleChange = new Vector3(1, 1, 1) * Time.deltaTime;

        if (Input.GetKey(KeyCode.V))
        {
            transform.localScale += scaleChange;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale -= scaleChange;
        }
    }

    private void RotateCube()
    {
        float rotationSpeed = 50f;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }    
    }
}
