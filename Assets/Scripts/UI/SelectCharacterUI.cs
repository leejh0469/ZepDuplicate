using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacterUI : MonoBehaviour
{
    private PlayerInfo _playerInfo;

    private void Awake()
    {
        _playerInfo = PlayerInfo.Instance;
    }

    public void SetCharacterIndex(int index)
    {
        _playerInfo.SetCharacterIndex(index);
    }
}
