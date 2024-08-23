using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void PlayFreeGame(){
        SceneManager.LoadScene(1);
    }

    public void Play1Lvl(){
        SceneManager.LoadScene(2);
    }

    public void Play2Lvl(){
        SceneManager.LoadScene(3);
    }

    public void Play3Lvl(){
        SceneManager.LoadScene(4);
    }

}
