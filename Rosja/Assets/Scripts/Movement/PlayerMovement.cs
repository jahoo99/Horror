using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _playerPosition;


    [SerializeField] private float _speed = 12f;



    void Update()
    {
       
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = _playerPosition.right * x + _playerPosition.forward * z;

        _controller.Move(move * _speed * Time.deltaTime);

    }
}
