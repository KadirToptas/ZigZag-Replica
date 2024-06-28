using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGrounObject;

    [SerializeField] private GameObject groundPrefab;

    private GameObject _newGroundObject;

    private int _groundDirection;
    
    
    void Start()
    {
        GenerateRandomNewGrounds();
    }

    public void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }


    private void CreateNewGround()
    {
        _groundDirection = Random.Range(0, 2);

        if (_groundDirection ==0)
        {
            _newGroundObject = Instantiate(groundPrefab, new Vector3(lastGrounObject.transform.position.x-1f,
                lastGrounObject.transform.position.y,
                lastGrounObject.transform.position.z),
                Quaternion.identity);

            lastGrounObject = _newGroundObject;
        }
        else
        {
            _newGroundObject = Instantiate(groundPrefab, new Vector3(lastGrounObject.transform.position.x,
                    lastGrounObject.transform.position.y,
                    lastGrounObject.transform.position.z +1f),
                Quaternion.identity);

                 lastGrounObject = _newGroundObject;
        }
    }
}
