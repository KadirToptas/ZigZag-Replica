using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValues()
    {
        yield return new WaitForSeconds(0.75f);
        _rb.useGravity = true;
        _rb.isKinematic = false;
    }
}
