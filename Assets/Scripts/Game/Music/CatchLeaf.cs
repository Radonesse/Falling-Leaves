using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchLeaf : MonoBehaviour
{
    public int count = 0;
    public AudioSource SoundOfCatch;

    void Awake(){
        SoundOfCatch = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other){
        SoundOfCatch.Play();
        Destroy(other.gameObject);
        count += 1;
    }
}
