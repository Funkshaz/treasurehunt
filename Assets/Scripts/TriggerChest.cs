using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChest : MonoBehaviour
{
    bool triggered;
    public GameObject open;
    public GameObject closed;
    public GameObject win;

    private void Update()
    
    
    {
        if (triggered == true && Items.hasKey == true && Input.GetKeyDown(KeyCode.E))
        {
            open.SetActive(true);
            closed.SetActive(false);
            StartCoroutine(GameWon());
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

    IEnumerator GameWon()
    {
        win.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        win.SetActive(true);
    }

}
