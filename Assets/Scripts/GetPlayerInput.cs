using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerInput : MonoBehaviour
{
    //private PlayerControls playerControls;
    //private void Awake()
    //{
    //    playerControls = new PlayerControls();
    //    playerControls.Player.Enable();
    //}

    //public Vector2 GetNormalizedMovementVector()
    //{
    //    Vector2 inputVector = playerControls.Player.Movement.ReadValue<Vector2>();
    //    inputVector = inputVector.normalized;
    //
    //    return inputVector;
    //}
    public Vector3 GetNormalizedMovementVector()
    {
        //    Vector2 inputVector = playerControls.Player.Movement.ReadValue<Vector2>();
        //    inputVector = inputVector.normalized;
        //
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 inputVector = new Vector3(horizontal, 0f, vertical).normalized;

        return inputVector;
    }
}
