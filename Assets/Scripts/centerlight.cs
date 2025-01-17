using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerlight : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position;
    }
}
