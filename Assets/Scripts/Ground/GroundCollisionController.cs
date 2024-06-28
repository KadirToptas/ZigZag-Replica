using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter _groundDataTransmitter;
    
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
}
