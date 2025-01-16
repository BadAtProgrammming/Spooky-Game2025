using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSound : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;


    float timer = 15;

    

    


    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= -0.007)
        {
            timer = 15;
        }

        if (timer <= 0)
        {
            source.PlayOneShot(clip);
        }
    }
}


