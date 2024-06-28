using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController _groundSpawnController;
    
    private Rigidbody _rb;

    [SerializeField] private float endYValue;

    private int _groundDirection; 
    void Start()
    {
        _groundSpawnController = FindObjectOfType<GroundSpawnController>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVerticalPosition();
    }   

    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <=endYValue)
        {
            SetRigidbodyValues();
            SetNewGroundPosition();
        }
    }

    private void SetNewGroundPosition()
    {
        _groundDirection = Random.Range(0, 2);

        if (_groundDirection == 0)
        {
            transform.position = new Vector3(_groundSpawnController.lastGrounObject.transform.position.x - 1f,
                _groundSpawnController.lastGrounObject.transform.position.y,
                _groundSpawnController.lastGrounObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(_groundSpawnController.lastGrounObject.transform.position.x,
                _groundSpawnController.lastGrounObject.transform.position.y,
                _groundSpawnController.lastGrounObject.transform.position.z +1f); 
        }

        _groundSpawnController.lastGrounObject = gameObject;
    }

    private void SetRigidbodyValues()
    {
        _rb.isKinematic = true;
        _rb.useGravity = false;
    }
}
