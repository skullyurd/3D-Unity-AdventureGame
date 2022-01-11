using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform targetCamera;
    [SerializeField] private Vector3 offset;                                                                                             

    void Update()
    {
        transform.position = targetCamera.position + offset;
    }
}
