using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundStart;

    public void Play(){
        soundStart.Play();
    }
}
