/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : TextHandler
{

    Rigidbody2D rb;
    float timesTalked;
    TextHandler == th;
    float canTalk;
    readonly float currentDialouge;
    float horz;
    float vert;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

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

    void FixedUpdate()
    {
       

        rb.velocity = new Vector2(rb.velocity.x, vert * 7);
        
        rb.velocity = new Vector2(horz * 7, rb.velocity.y);
    }
}*/
