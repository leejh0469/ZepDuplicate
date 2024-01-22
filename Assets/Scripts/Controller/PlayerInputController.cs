using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // InputSystem에서 키값이 입력되면 자동으로 OnMove, OnLook 함수가 실행됨
    public void OnMove(InputValue value)
    {
        Vector2 moveInputValue = value.Get<Vector2>().normalized;
        CallOnMoveEvent(moveInputValue);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if(newAim.magnitude >= .9f)
        {
            CallOnLookEvent(newAim);
        }
    }
}
