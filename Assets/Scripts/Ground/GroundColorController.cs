using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    private int _colorIndex =0;

    [SerializeField] private float lerpValue;

    [SerializeField] private float _time;

    private float currentTime;

    private void Update()
    {
        SetColorChangeTime();
        SetSmoothColorChanges();
    }
    
    private void SetColorChangeTime(){
        if (currentTime<=0 )
        {
            CheckColorIndexValues();    
            currentTime = _time;
        }

        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValues()
    {
        _colorIndex++;

        if (_colorIndex>= colors.Length)
        {
            _colorIndex = 0;
        }

    }

    private void SetSmoothColorChanges()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[_colorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }
}
