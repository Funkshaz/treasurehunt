using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTargetRotate : MonoBehaviour
{
    public GameObject player;
    public bool canRotate;

    // Start is called before the first frame update
    void Start()
    {
        canRotate = true;
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Period) && canRotate == true)
        {
            StartCoroutine(RotateDelay());
            transform.RotateAround(player.transform.position, Vector3.up, 90);
        }

        if (Input.GetKeyDown(KeyCode.Comma) && canRotate == true)
        {
            StartCoroutine(RotateDelay());
            transform.RotateAround(player.transform.position, Vector3.up, -90);
        }
    }
    IEnumerator RotateDelay()
    {
        canRotate = false;
        yield return new WaitForSeconds(1);
        canRotate = true;
    }
}
