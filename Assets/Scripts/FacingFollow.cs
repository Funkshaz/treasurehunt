using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingFollow : MonoBehaviour
{
    // Start is called before the first frame update

    public float smoothSpeed = 1f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
