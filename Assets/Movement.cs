using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rotationSpeed = 5f;

    private bool isRotating = false;
    private Vector3 previousMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            previousMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float rotationY = (currentMousePosition.x - previousMousePosition.x) * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationY);

            previousMousePosition = currentMousePosition;
        }
    }
}



