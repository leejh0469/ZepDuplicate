using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalkController : MonoBehaviour
{
    [SerializeField] private GameObject bellUI;
    [SerializeField] private GameObject talkScriptUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bellUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bellUI.SetActive(false);
            talkScriptUI.SetActive(false);
        }
    }
}
