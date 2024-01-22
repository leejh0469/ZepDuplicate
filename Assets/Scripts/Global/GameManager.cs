using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField] TextMeshProUGUI timeText;

    public List<GameObject> PlayerList;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager Instance
    {
        get
        {
            if(Instance == null)
                return null;
            else
                return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void UpdatePlayerList()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] npc = GameObject.FindGameObjectsWithTag("NPC");

        PlayerList = player.Concat(npc).ToList();
    }
}
