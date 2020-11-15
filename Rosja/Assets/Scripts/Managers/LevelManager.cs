using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour 
{
    private static LevelManager _instance;
    public static LevelManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject(typeof(LevelManager).ToString());
                go.AddComponent<LevelManager>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this as LevelManager;
       
    }   
    
    private int _menu = 0;
    private int _lvl = 1;
    private int _test = 2;

    
    public void FirstLevel()
    {
        SceneManager.LoadScene(_lvl, LoadSceneMode.Single); ;
    }
    public void Test()
    {
        SceneManager.LoadScene(_test, LoadSceneMode.Single); ; 
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(_menu, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public static bool gameIsPaused;
}