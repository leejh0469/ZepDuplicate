using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class PlayerListUI : MonoBehaviour
{
    [SerializeField] private Transform content;

    [SerializeField]
    List<TextMeshProUGUI> texts = new List<TextMeshProUGUI>();

    private void Awake()
    {
        texts = content.GetComponentsInChildren<TextMeshProUGUI>().ToList();
    }

    public void UpdateText(List<string> s)
    {
        int i;
        for(i = 0; i < s.Count; i++)
        {
            texts[i].text = s[i];
        }
        for(; i < texts.Count; i++)
        {
            texts[i].text = "";
        }
    }
}
