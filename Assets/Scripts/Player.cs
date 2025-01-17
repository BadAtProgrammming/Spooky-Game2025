using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Component door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("balls");
        if (collision.gameObject.tag == "Door")
        {
            Door door = collision.gameObject.GetComponent<Door>();
            if (Input.GetKey(KeyCode.E))
            {
                print("Cum");
                door.Open = true;
                transform.position = door.tP.transform.position;
            }
        }
    }
}
