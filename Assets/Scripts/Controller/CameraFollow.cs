using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _camera;


    private void FixedUpdate()
    {
        _camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
