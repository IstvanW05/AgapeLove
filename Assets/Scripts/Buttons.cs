using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Sprite[] charParts;
    public GlobalManager globalManager;
    public GameObject characterSelect;
    public Image currentSprite;
    public int i = 0;

    public void CharacterSelect()
    {
        characterSelect.SetActive(true);
    }

    public void ExitCharacterSelect()
    {
        characterSelect.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChangeCharacterAdd()
    {   
        i++;    
        if(i > charParts.Length - 1)
            i = 0;

        currentSprite.sprite = charParts[i];
        globalManager.SwitchCharAdd();
    }

    public void ChangeCharacterSubtract()
    {
        i--;
        if(i < 0)
            i = charParts.Length - 1;
        currentSprite.sprite = charParts[i];
        globalManager.SwitchCharSubtract();
    }
}