using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDialog : TextHandler
{
    bool canTalk;
    TextHandler th;
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
        if (canTalk && th.currentDialouge == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                shotAnim.SetBool("Walking", false);
                //times talked is a variable to keep track of what dialouge file to load
                timesTalked++;
                th.InitiateTalk(timesTalked);
            }
        }
        #endregion
    }
    private void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("GhostBox"))
        {
            //talkInstructionText.SetActive(true);
            canTalk = true;
        }
    }

    private void OnTriggerExit(Collider2D other)
    {
        if (other.CompareTag("GhostBox"))
        {
           // talkInstructionText.SetActive(false);
            canTalk = false;
        }
    }
}