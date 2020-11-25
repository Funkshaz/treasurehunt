using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceStar : MonoBehaviour
{
    public GameObject star;
    public Transform starSpawn;
    bool triggered;
    public GameObject starCode;
    public static bool starPlaced;
    private void Update()
    {
        if(triggered == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && Items.hasStar == true)
            {
                Instantiate(star, starSpawn);
                starPlaced = true;
                Riddles.ridStage = 5;
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
