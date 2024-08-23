using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBasketMoving : MonoBehaviour
{
    public Rigidbody2D basket;
    public AudioSource sound;

    void Awake(){
        sound = GetComponent<AudioSource>();
    }

    void Update(){
        if(basket.velocity.x != 0){
            sound.UnPause();
        }else{
            sound.Pause();
        }
    }
}
