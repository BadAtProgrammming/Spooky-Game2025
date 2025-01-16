using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karma : MonoBehaviour
{
    int KarmaPoints;
    [SerializeField] bool Ending;
    Scene CurrentScene;

    // when character runs out of time check karma points and see which ending happens
    private void Start()
    {
       CurrentScene = SceneManager.GetActiveScene();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            KarmaPoints += 1;
        }

        if(Ending = true && KarmaPoints >= 5 && CurrentScene.name == "Benjamin")
        {
            GoodEnding();
        }
        // put code here to check for things done during the game and add to karmapoints
        // if karma point is too low or high enough then Ending() to respectively bad or good ending
    }
    void GoodEnding()
    {
        // send to new scene with cutscene?
        SceneManager.LoadScene("GoodEnding");
    }

    void BadEnding()
    {
        // send to new scene with cutscene
    }
}
