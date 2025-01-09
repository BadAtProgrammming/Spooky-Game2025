using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.XPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    //the actual text object.
    public TextMeshProUGUI text;

    //gameobject that the text is on and background for the text.
    public GameObject textGO;
    public GameObject backgroundGO;

    //reference to animator to change animation based on dialouge.
    //public Animator shotAnim;
    //public Animator miloAnim;

    //reference to camera to change camera based on dialouge.
    public Camera cam;

    //an array of strings, which represent full dialouge files.
    public string[] dialouges;

    //the result of code to split the above strings into arrays, put into their own file array, therefore needing a double array.
    public string[][] result;

    //number of the current file that is being displayed.
    public int currentDialouge;

    //reads text from a localy saved file.
    StreamReader[] sr;

    void Start()
    {
        //creates an array of StreamReaders with the length of the amount of dialouge files.
        sr = new StreamReader[dialouges.Length];

        //makes an array of arrays with the first length of the amount of dialouges.
        result = new string[dialouges.Length][];

        //creates the dialouge file from a public int saved on a GameObject.
        for (int i = 1; i < dialouges.Length; i++)
        {

            if (!File.Exists($"Dialouge{i}.txt"))//only creates a new dialouge file if it doesn't exist.
            {
                //goes through the full string, making it into an array of strings in this case separated by "(splitline)".
                result[i] = dialouges[i].Split("(splitline)".ToLower(), StringSplitOptions.RemoveEmptyEntries);

                //StreamWriter creates the file and types out the array of split strings.
                using (StreamWriter sw = File.CreateText($"Dialouge{i}.txt"))
                {
                    foreach (string s in result[i])
                        sw.WriteLine(s);

                    sw.Flush();
                    sw.Close();
                }

            }

            //this for-loop does this entire process for the amount of different instances of dialouges you have.
        }
    }
    void Update()
    {
        //unless there is no dialouge file currently loaded, displayes the next dialouge line in that file.
        if (currentDialouge != 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DisplayNextLine();
            }
        }
    }

    //Starts reading a new dialouge file.
    public void InitiateTalk(int dialougeNum)
    {
        sr[dialougeNum] = new StreamReader($"Dialouge{dialougeNum}.txt");
        currentDialouge = dialougeNum;
        textGO.SetActive(true);
        backgroundGO.SetActive(true);
        DisplayNextLine();
    }


    void DisplayNextLine()
    {
        //gets the current line to see if it has any trigger words, explained better below.
        string text = sr[currentDialouge].ReadLine();
        //If the text is empty, it will set the current dialouge to 0 and turn off the textbox.
        if (text != null)
        {
            //This part is going to need a bit of a longer explanation.
            //It goes through the last part of the line of text to see if
            //the text contains a triggerword. This first one below checks
            //to see if the text contains the phrase "(camerazoom)", and if
            //it does, it will remove the last 12 characters of the text and
            //change the camera size to 2. Otherwise it will set it to it's
            //default value of 5 and check for the next phrase.
            //It is important that the written dialouge has these in order
            //at the end, as if it has camerazoom, but not at the end, it is
            //still going to remove the last 12 characters, breaking the text.
            if (text.ToLower().Contains("(camerazoom)"))
            {
                cam.orthographicSize = 2;
                text = text.Remove(text.Length - 12);
            }
            else
                cam.orthographicSize = 5;

            // if (text.ToLower().Contains("(shotshocked)")){ text = text.Remove(text.Length - 13);shotAnim.SetBool("Shocked", true);}else{shotAnim.SetBool("Shocked", false);}

            //if (text.ToLower().Contains("(shotstare)"))
            //{
            //text = text.Remove(text.Length - 11);
            //shotAnim.SetBool("Staring", true);
            // }
            //else
            //shotAnim.SetBool("Staring", false);

            //if (text.ToLower().Contains("(shottalk)"))
            //{
            //text = text.Remove(text.Length - 10);
            // shotAnim.SetBool("Talking", true);
            //}
            //else
            //shotAnim.SetBool("Talking", false);

            //if (text.ToLower().Contains("(milotalk)"))
            //{
            // text = text.Remove(text.Length - 10);
            //miloAnim.SetBool("Talking", true);
            //}
            //else
            // miloAnim.SetBool("Talking", false);

            //sets the text of the variable called text to be equal to the local variable text (i made it confusing on purpose sorry lmao)
            this.text.text = text;
        }
        else
        {
            //if the text is empty, that means the end of the dialouge file was reached, and it will turn off the dialouge box and set currentDialouge to 0
            currentDialouge = 0;
            textGO.SetActive(false);
            backgroundGO.SetActive(false);
            // shotAnim.SetBool("Talking", false);
            //miloAnim.SetBool("Talking", false);
        }
    }
}
