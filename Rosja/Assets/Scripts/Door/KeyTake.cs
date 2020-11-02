using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTake : MonoBehaviour
{
    [SerializeField]private GameObject _keyToDoors;
    private bool DoorkKey = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            DoorkKey = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            DoorkKey = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& DoorkKey)
        {

            Destroy(this.gameObject);
        }
    }
}
