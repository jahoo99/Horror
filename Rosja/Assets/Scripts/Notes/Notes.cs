using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public GameObject NotePanel;
    private bool _activePanel = false;
    private bool _inRange = false;
    private int _moving = 1;
    private int _stop = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            _inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            _inRange = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _inRange)
        {
            Debug.Log("No działa");
            NotePanel.SetActive(true);
            _activePanel = true;
            Time.timeScale = _stop;
        }
        if (_activePanel && Input.GetKeyDown(KeyCode.Q))
        {   
            Time.timeScale = _moving;
            NotePanel.SetActive(false);
            _activePanel = false;
        }
    }
}
