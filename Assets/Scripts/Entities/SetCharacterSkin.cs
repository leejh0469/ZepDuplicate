using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacterSkin : MonoBehaviour
{
    private SpriteRenderer _spriteRendere;
    private Animator _animator;
    private PlayerInfo _playerInfo;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRendere = GetComponent<SpriteRenderer>();
        _playerInfo = PlayerInfo.Instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentSkin();
        _playerInfo.OnSkinChange += SetCurrentSkin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetCurrentSkin()
    {
        _animator.runtimeAnimatorController = _playerInfo.GetCurrentAnimatorController();
        _spriteRendere.sprite = _playerInfo.GetCurrentSprite();
    }
}
