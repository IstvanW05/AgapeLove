using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public PlayerMovement Player;
    public Sprite[] charParts;
    public Slider volumeSlider;
    public GlobalManager globalManager;
    public GameObject characterSelect;
    public GameObject settingSelect;
    public GameObject pauseMenu;
    public GameObject creditsMenu;
    public Image currentSprite;

    public Image currentVol;
    public Sprite volumeHigh;
    public Sprite volLow;
    public Sprite volMute;
    private int i = 0;

    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            LoadSettings();
        }
        else
            LoadSettings();
    }

    public void Credits()
    {
        creditsMenu.SetActive(true);
    }

    public void ExitCredits()
    {
        creditsMenu.SetActive(false);
    }
    
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Player.DialogueStart();
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Player.DialogueEnd();
    }
    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void CharacterSelect()
    {
        characterSelect.SetActive(true);
    }

    public void SettingSelect()
    {
        settingSelect.SetActive(true);
    }

    public void ExitCharacterSelect()
    {
        characterSelect.SetActive(false);
    }

    public void ExitSettings()
    {
        settingSelect.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Apartment");
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveSettings();
        UpdateVolumeButton();
    }

    public void Mute()
    {
        if(AudioListener.volume == 0)
            AudioListener.volume = volumeSlider.value;
        else
            AudioListener.volume = 0;
        UpdateVolumeButton();
    }
    public void UpdateVolumeButton()
    {
        if(AudioListener.volume == 0)
            currentVol.sprite = volMute;
        else if(AudioListener.volume <= 0.4)
            currentVol.sprite = volLow;
        else
            currentVol.sprite = volumeHigh;
    }

    public void LoadSettings()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
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