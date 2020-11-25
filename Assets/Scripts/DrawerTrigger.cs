using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int jumpCounter;
    public GameObject drawers;
    public Transform drawerSpawn;
    private GameObject drawersInstance;

    private void OnTriggerEnter(Collider other)
    {
        jumpCounter += 1;

        if(jumpCounter == 3)
        {
            drawersInstance = Instantiate(drawers, drawerSpawn.position, drawerSpawn.rotation);           
        }
        
    }
    /*private void OnTriggerExit(Collider other)
    {
        if(jumpCounter == 3)
        {
            Destroy(drawersInstance);
            jumpCounter = 0;
        }

    }*/
}
