using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowCamera : MonoBehaviour
{
    // This things position (camera) should same with camera

    [SerializeField] GameObject thingToFallow;
    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFallow.transform.position + new Vector3(0, 0, -10);

    }
}
