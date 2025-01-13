using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    

    public GameObject Interactable;

    bool hasItem;

    // Start is called before the first frame update
    void Start()
    {
        Interactable = FindObjectOfType<Interactable>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Interactable.GetComponent<Interactable>().hasItem = hasItem;

        
    }

    private void Interacting()
    {
        hasItem = true;
        Interactable.GetComponent<Interactable>().hasItem = hasItem;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interacting();

        }

    }

  
}
