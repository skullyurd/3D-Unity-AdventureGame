using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startNewGameButton()
    {
        SceneManager.LoadScene(1);
    }


    public void quitGame()
    {
        Application.Quit();
    }
}
