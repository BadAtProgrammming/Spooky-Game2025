using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    int KarmaPoints;

    // when character runs out of time check karma points and see which ending happens

    private void Update()
    {
        // put code here to check for things done during the game and add to karmapoints
        // if karma point is too low or high enough then Ending() to respectively bad or good ending
    }
    void GoodEnding()
    {
        // send to new scene with cutscene?
    }

    void BadEnding()
    {
        // send to new scene with cutscene
    }
}
