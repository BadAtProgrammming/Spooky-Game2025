using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
