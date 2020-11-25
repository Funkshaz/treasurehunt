using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetDoorOpen : MonoBehaviour
{
    public Vector3 open = new Vector3(9.75f, 3, -6);
    public Vector3 closed = new Vector3(8, 3, -8);
    public Quaternion openRot;
    public Quaternion closedRot;
    public bool triggered;

    private void Start()
    {
        openRot = Quaternion.Euler(0, 90, 0);
        closedRot = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        if(triggered == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && Items.hasTeddy == true && Items.hasDuster == true)
            {
                transform.rotation = closedRot;
                transform.position = closed;
            }
            if (Input.GetKeyUp(KeyCode.E) && Items.hasTeddy == true && Items.hasDuster == true)
            {
                transform.rotation = openRot;
                transform.position = open;
            }
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        triggered = true;
    }

    private void OnTriggerExit(Collider other)
    {
        triggered = false;
        StartCoroutine(OpenDoor());

    }
    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(3);
        transform.rotation = openRot;
        transform.position = open;
    }
}
