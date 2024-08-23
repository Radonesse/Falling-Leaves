using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPrefs : MonoBehaviour
{
    void FixedUpdate(){
        if(Input.GetKeyDown(KeyCode.R)){
            PlayerPrefs.DeleteAll();
            Debug.Log("Player Prefs Reset");
        }
    }
}
