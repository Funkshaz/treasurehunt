using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public GameObject normalDOF;
    public GameObject mapDOF;
    public GameObject riddles;
    public GameObject text;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            normalDOF.SetActive(false);
            mapDOF.SetActive(true);
            riddles.SetActive(true);
        }
        else
        {
            normalDOF.SetActive(true);
            mapDOF.SetActive(false);
            riddles.SetActive(false);
        }
        if(Riddles.ridStage == 2)
        {
            var txt = text.GetComponent<Text>().text = "A fuzzy friend in need!\nSave him if you dare.\nVenture forth into\nthe monster's lair.";
        }
        if (Riddles.ridStage == 3)
        {
            var txt = text.GetComponent<Text>().text = "To see the moonlight\nshine so bright,\nlook where dreams\nare made at night.";
        }
        if (Riddles.ridStage == 4)
        {
            var txt = text.GetComponent<Text>().text = "It guides the sailors\n'cross the seas.\nPlace it where\nyou feel a breeze.";
        }
        if (Riddles.ridStage == 5)
        {
            var txt = text.GetComponent<Text>().text = "Should your face feel washed\nbut your appearance...not pristine,\nconsider REFLECTING\non how you get clean.\nShould your reflection\nnot get any clearer,\nperhaps you should try\n cleaning your mirror.";
        }
        if (Riddles.ridStage == 6)
        {
            var txt = text.GetComponent<Text>().text = "The key to bringing\na sunken treasure home,\nis searching the ocean\nwith a fine-toothed comb.";
        }
    }
}
