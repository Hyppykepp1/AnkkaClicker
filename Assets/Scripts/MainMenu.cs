using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("AnkkaClicker");
    }
    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("SettingsScreen");
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}