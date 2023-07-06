using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRotation : MonoBehaviour
{
    private float Z;
    private bool rotateZ;
    private float rotationSpeed;

    void Start()
    {
        Z = 0.0f;
        rotateZ = true;
        rotationSpeed = 75.0f;
    }

    void FixedUpdate()
    {
        if (rotateZ == true)
        {
            Z += Time.deltaTime * rotationSpeed;
        }
        transform.localRotation = Quaternion.Euler(0, 0, Z);
    }
}
