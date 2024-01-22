using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private PlayerInfo _playerInfo;
    [SerializeField] private TextMeshProUGUI playerNameText;

    private void Awake()
    {
        _playerInfo = PlayerInfo.Instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPlayerNameText(_playerInfo.Name);
        _playerInfo.OnNameChange += SetPlayerNameText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPlayerNameText(string name)
    {
        playerNameText.text = name;
    }

}
