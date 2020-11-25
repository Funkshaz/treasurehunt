using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerComb : MonoBehaviour
{
    bool triggered;
    public GameObject left;
    public GameObject right;

    private void Update()
    {
        if (triggered == true && LightTrigger.hasCode == true && Input.GetKeyDown(KeyCode.E))
        {
            left.SetActive(true);
            right.SetActive(true);
            Items.hasComb = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggered = true;
    }
    private void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
}
