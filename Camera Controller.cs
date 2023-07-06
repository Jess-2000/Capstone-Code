using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    private Vector3 offset;
   
    void Start()
    {
        offset = transform.position - Player.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
