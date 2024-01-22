using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParticipantController : MonoBehaviour
{
    [SerializeField] private PlayerListUI _playerListUI;

    public List<string> Participants = new List<string>();

    private void Start()
    {
        _playerListUI.UpdateText(Participants);
    }

    public void UpdateParticipantList()
    {
        List<PlayerData> list = GetComponentsInChildren<PlayerData>().ToList();
        Participants.Clear();
        foreach(var i in list)
        {
            Participants.Add(i.Name);
        }
        _playerListUI.UpdateText(Participants);
    }
}
