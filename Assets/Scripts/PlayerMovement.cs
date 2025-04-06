using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSmoothTime;
    public float Speed;
    
    public Vector3 PlayerInput;
    private CharacterController Controller;
    private Vector3 CurrentMoveVelocity;
    private Vector3 MoveDampVelocity;
    private bool isFrozen; 

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerInput = new Vector3
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0f,
            z = Input.GetAxisRaw("Vertical"),
        };

        if(PlayerInput.magnitude > 1f)
        {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput);

        CurrentMoveVelocity = Vector3.SmoothDamp(
            CurrentMoveVelocity,
            MoveVector * Speed,
            ref MoveDampVelocity,
            MoveSmoothTime
        );

        if(isFrozen == false)
            Controller.Move(CurrentMoveVelocity * Time.deltaTime);
    }

    public void DialogueStart()
    {
        isFrozen = true;
    }

    public void DialogueEnd()
    {
        isFrozen = false;
    }
}