using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    public void CheckInput()
    {
        if(inputField.text.Length > 10 || inputField.text.Length < 2)
        {
            Debug.Log("잘못된 입력");
            return;
        }
        else
        {
            Debug.Log(inputField.text);
            PlayerInfo.Instance.SetName(inputField.text);
            if(SceneManager.GetActiveScene().name == "StartScene")
                ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
