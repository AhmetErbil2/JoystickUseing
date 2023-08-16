using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{   
    [SerializeField] private Rigidbody rb;
    [SerializeField] private FixedJoystick joystick;
    [SerializeField] private float speed;
    public Transform PlayerChildTransform;

    private float _horizontal;
    private float _vertical;




    private void Update()
    {
        GetMoveInput();
    }
    private void FixedUpdate()
    {


        SetMovement();
        OnConnectedToServer();



    }



    private void SetMovement()
    {
        rb.velocity = GetNewVelocity();

    }
    private void OnConnectedToServer()
    {
        if (_horizontal != 0 || _vertical !=0)
        {
            PlayerChildTransform.rotation = Quaternion.LookRotation(GetNewVelocity());
        }    
    }


    private Vector3 GetNewVelocity()
    {
        return new Vector3(_horizontal, rb.velocity.y*0, _vertical) * speed*10 * Time.fixedDeltaTime;
    }

    private void GetMoveInput()
    {
        _horizontal = joystick.Horizontal;
        _vertical = joystick.Vertical;
    }















}
