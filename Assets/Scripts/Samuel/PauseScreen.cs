using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{

    public GameObject pauseScreen;

    bool pauseOn;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseOn == false)
        {
            pauseScreen.SetActive(true);
            
            pauseOn = true;

            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseOn == true)
        {
            pauseScreen.SetActive(false);

            pauseOn = false;

            Time.timeScale = 1;
        }
    }

    public void Continue()
    {
        pauseScreen.SetActive(false);
        pauseOn = false;
        Time.timeScale = 1;
    }

    

}
