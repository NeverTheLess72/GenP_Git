using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform cube;
    public Vector3 Offset;
    void Update()
    {
        transform.position = cube.position + Offset;
    }
}
