using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverScr : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpreed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        float carSpeed = Input.GetAxis("Vertical") * moveSpreed * Time.deltaTime;
        float steerAmount = 0;

        if (carSpeed != 0)
        {
            steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        }

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, carSpeed, 0);

    }
}
