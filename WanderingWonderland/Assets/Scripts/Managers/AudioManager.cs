using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    public AudioMixer mixer;
    public AudioSettings[] settings;

    private float masterValue = 0;

    private enum AudioGroups
    {
        Master,
        Music,
        SFX,
        Ambient
    };

    private void Awake()
    {
        instance = GetComponent<AudioManager>();
    }

    private void Start()
    {
        for (int i = 0; i < settings.Length; i++)
        {
            settings[i].Initialize();
        }
    }

    void CapVolume(float value)
    {
        if(value >= masterValue)
        {
            value = masterValue;
        }
    }

    public void SetMasterVolume(float value)
    {
        masterValue = value;
        settings[(int)AudioGroups.Master].SetExposedParam(value);
    }

    public void SetMusicVolume(float value)
    {
        CapVolume(value);
        settings[(int)AudioGroups.Music].SetExposedParam(value);
    }

    public void SetSFXVolume(float value)
    {
        CapVolume(value);
        settings[(int)AudioGroups.SFX].SetExposedParam(value);
    }

    public void SetAmbientVolume(float value)
    {
        CapVolume(value);
        settings[(int)AudioGroups.Ambient].SetExposedParam(value);
    }
}

[System.Serializable]
public class AudioSettings
{
    public string exposedParam;
    public Slider slider;

    public void Initialize()
    {
        slider.value = PlayerPrefs.GetFloat(exposedParam);
    }

    public void SetExposedParam(float value)
    {
        AudioManager.instance.mixer.SetFloat(exposedParam, value);
        PlayerPrefs.SetFloat(exposedParam, value);
    }
}

