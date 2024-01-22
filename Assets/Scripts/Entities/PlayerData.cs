using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private string playerName;
    private ParticipantController _participantController;
    public string Name
    {
        get
        {
            return playerName;
        }
        set
        {
            playerName = value;
            _participantController.UpdateParticipantList();
        }
    }

    private void Awake()
    {
        _participantController = GetComponentInParent<ParticipantController>();
    }

    private void Start()
    {
        if(this.gameObject.tag == "Player")
        {
            PlayerInfo.Instance.OnNameChange += SetName;
            Name = PlayerInfo.Instance.Name;
        }
        else
        {
            Name = playerName;
        }
    }

    private void SetName(string name)
    {
        Name = name;
    }

    private void OnDestroy()
    {
        _participantController.UpdateParticipantList();
    }
}
