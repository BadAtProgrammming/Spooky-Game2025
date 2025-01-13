using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    }
}
