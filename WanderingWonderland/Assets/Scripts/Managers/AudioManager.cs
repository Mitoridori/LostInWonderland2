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

    public void SetMasterVolume(float value)
    {
        settings[(int)AudioGroups.Master].SetExposedParam(value);
    }

    public void SetMusicVolume(float value)
    {
        settings[(int)AudioGroups.Music].SetExposedParam(value);
    }

    public void SetSFXVolume(float value)
    {
        settings[(int)AudioGroups.SFX].SetExposedParam(value);
    }

    public void SetAmbientVolume(float value)
    {
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
        slider.value = PlayerPrefs.GetFloat(exposedParam, 0.75f);
    }

    public void SetExposedParam(float value)
    {
        AudioManager.instance.mixer.SetFloat(exposedParam, Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat(exposedParam, value);
    }
}

