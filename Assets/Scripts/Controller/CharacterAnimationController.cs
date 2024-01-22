using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : CharacterAnimations
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    protected override void Awake()
    {
        base.Awake();

    }

    private void Start()
    {
        characterController.OnMoveEvent += MoveAnimation;
    }

    private void MoveAnimation(Vector2 vector)
    {
        animator.SetBool(IsWalking, vector.magnitude > .5f);
    }
}
