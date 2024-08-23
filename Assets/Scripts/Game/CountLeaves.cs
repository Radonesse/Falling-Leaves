using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountLeaves : MonoBehaviour
{
    public GameObject basket;
    public int Count;

    void Update(){
        Count = basket.GetComponent<CatchLeaf>().count;
        GetComponent<TMP_Text>().text = Count.ToString();
    }
}
