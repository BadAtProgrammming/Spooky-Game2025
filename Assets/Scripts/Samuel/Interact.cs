using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    

    public GameObject Interactable;

    bool hasItem;

    bool interacting;

    // Start is called before the first frame update
    void Start()
    {
        Interactable = FindObjectOfType<Interactable>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Interactable.GetComponent<Interactable>().hasItem = hasItem;

        if (Input.GetKeyDown(KeyCode.E) && interacting == true)
        {
            Interacting();

        }
    }

    private void Interacting()
    {
        hasItem = true;
        Interactable.GetComponent<Interactable>().hasItem = hasItem;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        interacting = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        interacting = false;

    }

}
