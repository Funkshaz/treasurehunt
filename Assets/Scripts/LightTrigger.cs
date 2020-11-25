using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public GameObject roomLight;
    public GameObject moonLight;
    public GameObject starCode;
    bool triggered;
    public GameObject teddy;
    public Transform teddySpawn;
    public Color starCodeColor;
    public float alpha;
    public static bool hasCode;

    private void Start()
    {
        starCodeColor = starCode.GetComponent<TextMesh>().color;
    }
    private void Update()
    {
        if (triggered == true)
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(teddy, teddySpawn);
                Riddles.ridStage = 4;
            }
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        triggered = true;

        if (PlaceStar.starPlaced == true)
        {
            alpha += 0.1f * Time.deltaTime;
        }
        if (CleanMirror.mirrorCleaned == true && Trigger.doorClosed == true)
        {
            starCode.transform.rotation = Quaternion.Euler(0, 90, 0);
            hasCode = true;
        }
        else
        {
            starCode.transform.rotation = Quaternion.Euler(0, 270, 0);
        }


        starCode.GetComponent<TextMesh>().color = new Color(255, 255, 255, alpha);
        if (roomLight.GetComponent<Light>().intensity > 0.25f)
        {
            roomLight.GetComponent<Light>().intensity -= 0.25f * Time.deltaTime;
        }

        if (moonLight.GetComponent<Light>().intensity < 1f)
        {
            moonLight.GetComponent<Light>().intensity += 0.25f * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        alpha = 0;
        starCode.GetComponent<TextMesh>().color = new Color(255, 255, 255, alpha);

        triggered = false;
        roomLight.GetComponent<Light>().intensity = 1;
        moonLight.GetComponent<Light>().intensity = 0;
        //starCodeColor = Color.clear;
    }
}
