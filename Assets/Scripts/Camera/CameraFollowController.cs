using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{

    [SerializeField] private Transform ballTransform;

    private Vector3 _offset;

    [SerializeField] [Range(0,3)] private float lerpValue;

    private Vector3 _newPos;
    void Start()
    {
        _offset = transform.position - ballTransform.position;
    }

    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }
    
    private void SetCameraSmoothFollow()
    {

        _newPos = Vector3.Lerp(transform.position, ballTransform.position + _offset, lerpValue * Time.deltaTime);

        transform.position = _newPos;
    }
}
