using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            LevelManager.Instance.FirstLevel();
        }    
        else if (Input.GetKeyDown(KeyCode.T))
        {
            LevelManager.Instance.Test();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            LevelManager.Instance.QuitGame();
        }
    }
}
