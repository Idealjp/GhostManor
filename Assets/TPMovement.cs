﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPMovement : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 12f;
    public float smoothTurn = 0.1f;
    float smoothTurnSpeed = 0.08f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurn, smoothTurnSpeed);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * playerSpeed * Time.deltaTime);
        }
    }
}
