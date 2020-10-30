 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused;
    [SerializeField]
    private GameObject _pauseMenuUI;
    private float _moving = 1f;
    private float _stop = 0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseClick();

        }
        if (Input.GetKeyDown(KeyCode.Q)&& gameIsPaused)
        {
            MainMenu();

        }
    }
    public void PauseClick()
    {

        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            PauseOn();
        }
    }
    public void Resume()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = _moving;
        gameIsPaused = false;
    }
    public void PauseOn()
    {
        _pauseMenuUI.SetActive(true);
        Time.timeScale = _stop;
        gameIsPaused = true;
    }
    public void MainMenu()
    {
        Time.timeScale = _moving;
        LevelManager.Instance.MainMenu();
    }
    public void Quit()
    {
        LevelManager.Instance.QuitGame();
    }
}