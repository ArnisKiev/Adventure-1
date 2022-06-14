using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float Speed { get; set; } = 15;

    private Vector3 _move;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        _move = transform.right * x + transform.forward * z;



        controller.Move(_move * Speed * Time.deltaTime);






    }
}
