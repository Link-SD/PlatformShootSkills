﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    public float Speed = 5;

    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void StartMovingInDirection(Vector3 direction)
    {
        rigidBody.AddForce(direction * Speed * Time.deltaTime);
    }

    public void StopMoving()
    {
        rigidBody.velocity = Vector3.zero;
    }
}
