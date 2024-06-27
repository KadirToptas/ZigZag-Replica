using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{

    [SerializeField] private BallDataTransmitter _ballDataTransmitter;

    [SerializeField] private float ballMoveSpeed;

    private void Update()
    {
        SetBallMovement();
    }
    
    private void SetBallMovement()
    {
        transform.position += _ballDataTransmitter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
