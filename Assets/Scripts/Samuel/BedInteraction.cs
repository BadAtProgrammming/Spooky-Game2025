using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedInteraction : MonoBehaviour
{

    bool goodEnding;
    bool onBed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && onBed == true && goodEnding == false)
        {
            SceneManager.LoadScene(5);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        onBed = true;
    }
    private void OnTriggerExit(Collider other)
    { 
        onBed = false;
    }
}
