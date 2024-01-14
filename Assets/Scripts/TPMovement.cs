using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class TPMovement : NetworkBehaviour
{
    public static PlayerMovement Instance { get; private set; }

    public CharacterController controller;
    [SerializeField] private float playerSpeed = 12f;
    [SerializeField] private float smoothTurn = 0.1f;
    [SerializeField] private float smoothTurnSpeed = 0.08f;

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 inputVector = new Vector3(horizontal, 0f, vertical).normalized;

        if (inputVector.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(inputVector.x, inputVector.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurn, smoothTurnSpeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(inputVector * playerSpeed * Time.deltaTime);
        }
    }
}
