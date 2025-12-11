using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class SettingsMenuManager : MonoBehaviour
{
    // Master, Music, and Volume Slider
    public Slider masterVol, musicVol, sfxVol; // May want to double check these
    public AudioMixer mainAudioMixer;

    public void ChangeMasterVolume() {
        mainAudioMixer.SetFloat("MasterVolume", masterVol.value);
    }

    public void ChangeMusicVolume() {
        mainAudioMixer.SetFloat("MusicVolume", musicVol.value);
    }

    public void ChangeSFXVolume() {
        mainAudioMixer.SetFloat("SFXVolume", sfxVol.value);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
