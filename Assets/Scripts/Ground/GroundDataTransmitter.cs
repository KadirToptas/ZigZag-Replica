using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
  [SerializeField] private GroundFallController _groundFallController;

  public void SetGroundRigidbodyValues()
  {
    StartCoroutine(_groundFallController.SetRigidbodyValues());
  }
}
