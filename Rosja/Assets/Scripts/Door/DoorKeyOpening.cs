using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyOpening : MonoBehaviour
{

    [HideInInspector]public bool keyOwning = false;
    private bool _doorDistance = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            _doorDistance = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            _doorDistance = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _doorDistance && keyOwning)
        {
            Destroy(this.gameObject);
        }
    }
}
