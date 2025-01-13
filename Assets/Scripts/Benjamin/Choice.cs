using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    // use file to disable things depending on what the player chooses to do ingame (door A disables door B. maybe play a sound?

    
    [SerializeField] GameObject SideObject;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SideObject.SetActive(false);
        }
    }

}
