using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance;

    public string Name { get; private set; }

    public List<AnimatorController> animatorControllers = new List<AnimatorController>();
    public List<Sprite> sprites = new List<Sprite>();

    [SerializeField] private Image selectImage;

    public int CharacterIndex = 0;

    public event Action<string> OnNameChange;
    public event Action OnSkinChange;

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

    public static PlayerInfo Instance
    {
        get
        {
            if( instance == null)
            {
                return null;
            }
            else
            {
                return instance;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetSelectImage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallOnNameChange(string name)
    {
        OnNameChange?.Invoke(name);
    }

    public void CallOnSkinChange()
    {
        OnSkinChange?.Invoke();
    }

    public void SetName(string name)
    {
        Name = name;
        CallOnNameChange(name);
    }

    public void SetCharacterIndex(int index)
    {
        CharacterIndex = index;
        CallOnSkinChange();
    }

    public void SetSelectImage()
    {
        selectImage.sprite = sprites[CharacterIndex];
    }

    public Sprite GetCurrentSprite()
    {
        return sprites[CharacterIndex];
    }

    public AnimatorController GetCurrentAnimatorController()
    {
        return animatorControllers[CharacterIndex];
    }
}
