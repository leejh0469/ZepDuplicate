using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAimRotation : MonoBehaviour
{
    private CharacterController _controller;
    
    [SerializeField] private SpriteRenderer _characterSpriteRenderer;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += Aim;
    }

    private void Aim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        _characterSpriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
