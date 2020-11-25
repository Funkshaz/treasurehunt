using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetDoor : MonoBehaviour
{
    public GameObject closetDoorOpen;
    bool triggered;

    private void Update()
    {
        if(triggered == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                Instantiate(closetDoorOpen);
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
    }
}
