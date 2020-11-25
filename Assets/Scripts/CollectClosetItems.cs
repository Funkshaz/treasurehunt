using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectClosetItems : MonoBehaviour
{
    public GameObject teddy;
    public GameObject duster;
    bool triggered;
    //public BoxCollider openClosetDoorTrigger;
    public GameObject openClosetDoor;


    private void Update()
    {
        if(triggered == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(teddy);
                Destroy(duster);
                Items.hasDuster = true;
                Items.hasTeddy = true;
                Riddles.ridStage = 3;
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
