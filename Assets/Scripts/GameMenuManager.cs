using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DitIsEenTrigger()
    {
        SceneManager.LoadScene(2);
    }
}
