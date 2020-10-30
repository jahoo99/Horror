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
    
    private int menu = 0;
    private int lvl = 1;


    public void FirstLevel()
    {
        SceneManager.LoadScene(lvl, LoadSceneMode.Single); ; //zmienić na indeksy
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(menu, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}