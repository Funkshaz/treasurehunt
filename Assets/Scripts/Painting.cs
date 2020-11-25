using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public bool touchedPainting;

    private void OnTriggerEnter(Collider other)
    {
        touchedPainting = true;
    }
}
