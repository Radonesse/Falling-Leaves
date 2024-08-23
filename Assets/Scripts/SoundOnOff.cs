using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public AudioSource[] effects;
    public AudioSource[] music;
    public Toggle MusicToggleBool, EffectsToggleBool;

    void Awake(){
        SetInAwake("Music", MusicToggleBool);
        SetInAwake("Effects", EffectsToggleBool);
    }

    public void MusicToggle(){
        OnToggleSwitch("Music", music);
    }
    public void EffectsSoundToggle(){
        OnToggleSwitch("Effects", effects);
    }

    void SetInAwake(string key, Toggle toggle){
        if(PlayerPrefs.GetInt(key) == -1){
            toggle.isOn = true;
            PlayerPrefs.SetInt(key, -1);
            PlayerPrefs.Save();
        }
    }
    
    void OnToggleSwitch(string key, AudioSource[] obj){
        PlayerPrefs.SetInt(key, PlayerPrefs.GetInt(key)*-1);
        PlayerPrefs.Save();
        for (int i = 0; i < obj.Length; i++){
            obj[i].enabled = !obj[i].enabled;
        }
    }
}
