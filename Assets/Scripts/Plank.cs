using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plank : MonoBehaviour
{
    public int jumpCounter;
    public GameObject painting;
    public GameObject drawers;
    public Transform drawerSpawn;
    private GameObject drawersInstance;

    private void OnTriggerEnter(Collider other)
    {
        if(painting.GetComponent<Painting>().touchedPainting == true)
        {
            jumpCounter += 1;
            painting.GetComponent<Painting>().touchedPainting = false;
            


        }

        if (jumpCounter == 3)
        {
            drawersInstance = Instantiate(drawers, drawerSpawn.position, drawerSpawn.rotation);
        }
    }
}
