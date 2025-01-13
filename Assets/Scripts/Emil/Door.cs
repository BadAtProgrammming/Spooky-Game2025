using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameObject DoorObj;
    private bool animated;
    public bool Open;
    public Transform tP;
    float Ypositionincrease;

    private void Start()
    {
        DoorObj = GetComponentInChildren<GameObject>();
        Open = false;
        Ypositionincrease = DoorObj.transform.localScale.y * 0.5f;
    }

    private void Update()
    {
       if(Open == true && animated == false)
        {
            animated = true;
            DoorObj.transform.Translate(0, Ypositionincrease, 0);
            DoorObj.transform.Rotate(0, 0, 90, Space.Self);
        }
       if(Open == false && animated == true)
        {
            animated = false;
            DoorObj.transform.Translate(0, -Ypositionincrease, 0);
            DoorObj.transform.Rotate(0, 0, -90, Space.Self);
        }
    }
}
