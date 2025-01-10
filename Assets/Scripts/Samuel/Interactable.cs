using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public GameObject interactable;
    public GameObject objectToDestroy;

    public bool hasItem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasItem == false)
        {
            interactable.SetActive(false);
        }

        if (hasItem == true)
        {
            interactable.SetActive(true);
            Destroy(objectToDestroy);
        }

       
    }
	
  
}
