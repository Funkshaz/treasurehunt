using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanMirror : MonoBehaviour
{
    bool triggered;
    public Material cleanMirror;
    public static bool mirrorCleaned;

    private void Update()
    {
        if (triggered == true && Items.hasDuster == true && Trigger.doorClosed == true && mirrorCleaned == false)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                transform.GetComponent<MeshRenderer>().material = new Material(cleanMirror);
                mirrorCleaned = true;
                Riddles.ridStage = 6;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        triggered = true;
    }
}
