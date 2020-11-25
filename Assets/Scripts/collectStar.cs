using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectStar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Items.hasStar = true;
        Destroy(this.gameObject);
        Riddles.ridStage = 2;
    }
}
