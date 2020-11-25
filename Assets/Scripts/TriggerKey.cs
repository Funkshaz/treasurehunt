using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKey : MonoBehaviour
{
    bool triggered;

    private void Update()
    {
        if (triggered == true && Items.hasComb == true && Input.GetKeyDown(KeyCode.E))
        {
            Items.hasKey = true;
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
