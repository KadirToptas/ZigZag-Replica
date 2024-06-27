using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    [SerializeField] private BallInputController _ballInputController;
  
    
    public Vector3 GetBallDirection()
    {
        return _ballInputController.ballDirection;
    }
}
