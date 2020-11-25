using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float smoothSpeed = 1f;
    public Transform target;
    public Vector3 NE = new Vector3(-15, 14.75f, -15);
    public Vector3 NW = new Vector3(15, 14.75f, -15);
    public Vector3 SW = new Vector3(15, 14.75f, 15);
    public Vector3 SE = new Vector3(-15, 14.75f, 15);
    public Transform camFollow;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    public Transform facing;

    void Start()
    {
        offset = NE;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(facing);

    }
}