using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Camera attachedCamera;
    public float minYAngle = 30f, maxYAngle = 80f;
    public float xSpeed = 120f, ySpeed = 120f;

    private void Rotate()
    {
        // get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        // Getcurrent euler
        Vector3 euler = transform.eulerAngles;
        //rotate current euler
        euler.x -= mouseY * ySpeed * Time.deltaTime;
        euler.y += mouseX * xSpeed * Time.deltaTime;
        // apply to transform
        transform.eulerAngles = euler;
    }

    void Start()
    {
        Rotate();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Rotate();
        }
    }
}
