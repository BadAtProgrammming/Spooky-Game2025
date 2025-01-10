using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    bool interacting;
    bool hasItem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interacting == true)
        {
            Interact();
        }
    }
	
    private void Interact()
    {
        Destroy(gameObject);
        hasItem = true;
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
