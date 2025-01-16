using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SleepTimer : MonoBehaviour
{
    [SerializeField]
    float timer;
    

    [SerializeField]
    TextMeshProUGUI timerText;


    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        timerText.text = timer + "";

        if (timer <= 0)
        {
            GameOver();
        }

      
    }

    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }

}
