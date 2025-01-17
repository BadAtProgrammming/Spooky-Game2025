using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    [SerializeField] GameObject[] cutscenes;
    int currentcutscene;
    bool On; // is script on or off?
    [SerializeField] string newscene;
    [SerializeField] int endofcts;

    // Start is called before the first frame update
    void Start()
    {
        On = true;
        currentcutscene = 0;
        cutscenes[currentcutscene].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (On == true)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Backspace)) // press any of these buttons and it goes to the next cutscene and disables current cutscene image.
            {
                cutscenes[currentcutscene].SetActive(false);
                currentcutscene += 1;
                cutscenes[currentcutscene].SetActive(true);

            }

            if (currentcutscene >= endofcts) // if currentcutscene is 3 or higher go to main scene
            {
                SceneManager.LoadScene(newscene);
            }
        }

    }

    /* stole my own code from another project, ignore;
    public void PlayCutscenes() 
    {

        cutscenes[currentcutscene].SetActive(true);
        On = true;

    }
    */ 
}
