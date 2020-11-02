using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyOpening : MonoBehaviour
{

    private bool KeyOwning = false;
    private bool DoorkDistance = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            DoorkDistance = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            DoorkDistance = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DoorkDistance)
        {
            Destroy(this.gameObject);
        }
    }
}
