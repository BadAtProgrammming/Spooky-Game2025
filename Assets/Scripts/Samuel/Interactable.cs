using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public GameObject interactable;
    public GameObject objectToDestroy;

    

    public bool hasItem;


    // Update is called once per frame
    void Update()
    {
        if (hasItem == false)
        {
            interactable.SetActive(false);
            objectToDestroy.SetActive(true);
        }

        if (hasItem == true)
        {
            interactable.SetActive(true);
            objectToDestroy.SetActive(false);
           
        }


       
       
        
    }

    
	
  
}
