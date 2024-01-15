using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour { 

    //public static PlayerMovement Instance { get; private set; }
    
    public CharacterController controller;
    [SerializeField] private float playerSpeed = 12f;
    [SerializeField] private float smoothTurn = 0.1f;
    [SerializeField] private float smoothTurnSpeed = 0.08f;
    //------------------------
    //[SerializeField] private float playerSpeed = 12f;
    [SerializeField] private GetPlayerInput playerInput;
    // Update is called once per frame
    private void Update()
    {
        //Get input from GetPlayerInput.cs
        Vector3 inputVector = playerInput.GetNormalizedMovementVector();
        //Create Vector3 movement direction
        //Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.z);

        //-------------------------------------
        if (inputVector.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(inputVector.x, inputVector.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurn, smoothTurnSpeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(inputVector * playerSpeed * Time.deltaTime);
        }
        //--------------------------------------

        //player collider stats and check
        //float playerWidth = .6f;
        //float playerHeight = 1.5f;
        //float moveDistance = playerSpeed * Time.deltaTime;
        //bool blocked = Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerWidth, moveDirection, moveDistance);

        //if (blocked)//trying to move one direction if blocked
        //{
            //try moving along x axis if z is blocked
        //    Vector3 moveXDirection = new Vector3(moveDirection.x, 0f, 0f).normalized;
        //    blocked = Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerWidth, moveXDirection, moveDistance);

        //    if (!blocked)
        //    {
        //        moveDirection = moveXDirection;
        //    }
        //    else
        //    {
                //try moving along z axis if x is blocked
        //        Vector3 moveZDirection = new Vector3(0f, 0f, moveDirection.z).normalized;
        //        blocked = Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerWidth, moveZDirection, moveDistance);
        //
        //        if (!blocked)
        //        {
        //            moveDirection = moveZDirection;
        //        }
        //        else
        //        {
                    //blocked
        //        }
        //    }
        //}

        //if (!blocked)//player moves
        //{
        //    transform.position += moveDirection * moveDistance;
        //}
        
        //turn towards movement direction
        //float smoothTurnSpeed = 10f;
        //transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * smoothTurnSpeed);
    }
}
