using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDialog : MonoBehaviour
{
    public bool hungryTalk;
    public bool hairTalk;
    public bool guyTalk;
    public bool canTalk;
    public TextHandler th;
    int timesTalked;
    // Start is called before the first frame update
    void Start()
    {

    }




    // Update is called once per frame
    void Update()
    {
        //th is a reference to the textHandler script
        #region Talking
        if (guyTalk && th.currentDialouge == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //shotAnim.SetBool("Walking", false);
                //times talked is a variable to keep track of what dialouge file to load
                timesTalked++;
                th.InitiateTalk(timesTalked);
            }
        }
        if (hairTalk && th.currentDialouge == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //shotAnim.SetBool("Walking", false);
                //times talked is a variable to keep track of what dialouge file to load
                timesTalked++;
                th.InitiateTalk(timesTalked);
            }
        }
        if (hungryTalk && th.currentDialouge == 2)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //shotAnim.SetBool("Walking", false);
                //times talked is a variable to keep track of what dialouge file to load
                timesTalked++;
                th.InitiateTalk(timesTalked);
            }
        }
        #endregion
    }
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("GhostHungry"))
        {
            //talkInstructionText.SetActive(true);
            hungryTalk = true;
        }
        if (Other.CompareTag("GhostHair"))
        {
            //talkInstructionText.SetActive(true);
            hairTalk = true;
        }
        if (Other.CompareTag("GhostGuy"))
        {
            guyTalk = true;
        }

    }

    private void OnTriggerExit(Collider Other)
    {
        if (Other.CompareTag("GhostHungry"))
        {
           
            hungryTalk = false;
        }
        if (Other.CompareTag("GhostHair"))
        {
          
            hairTalk = false;
        }
        if (Other.CompareTag("GhostGuy"))
        {
            guyTalk = false;
        }
    }
}