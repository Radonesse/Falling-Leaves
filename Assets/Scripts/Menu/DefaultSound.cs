using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSound : MonoBehaviour
{
    void Awake(){
        SetDefault("Music");
        SetDefault("Effects");
        PlayerPrefs.Save();
    }

    void SetDefault(string key){
        if (PlayerPrefs.GetInt(key) != -1){
            PlayerPrefs.SetInt(key, 1);
        }
    }
}
