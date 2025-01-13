using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject DoorObj;
    [SerializeField] bool animated;
    public bool Open;
    public Transform tP;
    [SerializeField] float positionincrease;

    private void Start()
    {
        Open = false;
        positionincrease = DoorObj.transform.localScale.y * 0.5f;
    }

    private void Update()
    {
       if(Open == true && animated == false)
        {
            print("test");
            DoorObj.transform.Rotate(0, 0, 90, Space.World);
            DoorObj.transform.Translate(-positionincrease, positionincrease, 0, Space.World);
            animated = true;
        }
       if(Open == false && animated == true)
        {
            animated = false;
            DoorObj.transform.Rotate(0, 0, -90, Space.World);
            DoorObj.transform.Translate(positionincrease, -positionincrease, 0, Space.World);
        }
    }
}
