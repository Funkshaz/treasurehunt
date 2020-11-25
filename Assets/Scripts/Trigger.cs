using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Vector3 open = new Vector3(9.75f, 3, -6);
    public Vector3 closed = new Vector3(8, 3, -8);
    public Quaternion openRot;
    public Quaternion closedRot;
    public bool triggered;
    public GameObject door;
    public static bool doorClosed;


    private void Start()
    {
        openRot = Quaternion.Euler(0, 90, 0);
        closedRot = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        if (Items.hasTeddy == true && Items.hasDuster == true)
        {
            transform.GetComponent<BoxCollider>().enabled = true;
        }

        if (triggered == true)
        {
            
            if (Input.GetKeyDown(KeyCode.E) && Items.hasTeddy == true && Items.hasDuster == true)
            {
                door.transform.rotation = closedRot;
                door.transform.position = closed;
                doorClosed = true;
            }
            if (Input.GetKeyUp(KeyCode.E) && Items.hasTeddy == true && Items.hasDuster == true)
            {
                StartCoroutine(OpenDoor());
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
        door.transform.rotation = openRot;
        door.transform.position = open;
        doorClosed = false;
    }
}
