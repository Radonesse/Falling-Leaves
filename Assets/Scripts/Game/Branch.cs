using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    public GameObject leaf_0, leaf_1, leaf_2, fallingLeaf;
    public int PubVector = 29;
    const int deltaTime = 30;
    public int time = 0;
    float gravity = 3f;

    void Awake(){
        time = Random.Range(0, 9*deltaTime);
    }

    void FixedUpdate(){
        PatternLeaves();
        LeafFalling();
    }

    void PatternLeaves(){
        switch(time){
            case 10*deltaTime:
                leaf_1.SetActive(true);
                time += 1;
                break;
            case 11*deltaTime:
                leaf_2.SetActive(true);
                time += 1;
                break;
            case 12*deltaTime:
                leaf_0.SetActive(true);
                time += 1;
                break;
            case 13*deltaTime:
                fallingLeaf = Instantiate(leaf_0, leaf_0.GetComponent<Transform>().position, Quaternion.identity);
                leaf_1.SetActive(false);
                leaf_2.SetActive(false);
                leaf_0.SetActive(false);
                time += Random.Range(1, 4*deltaTime);
                break;
            case 20*deltaTime:
                time = 0;
                break;
            default:
                time += 1;
                break;
        }
    }

    void LeafFalling(){
        if (fallingLeaf != null){
            fallingLeaf.GetComponent<Transform>().position += new Vector3(0, -1, 0)*gravity*Time.deltaTime;
        }
    }
}
