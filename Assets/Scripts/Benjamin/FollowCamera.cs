using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Camera CM;
    Collider playercoll;
    // Start is called before the first frame update
    void Start()
    {
        playercoll = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "CameraSpace")
        {
            CM.transform.position = collision.gameObject.transform.position;
        }
    }

    // big squares, uses colliders to send camera to the squares, if interact with door send camera to a rooms square

}
