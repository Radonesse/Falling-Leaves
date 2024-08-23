using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public GameObject Canvas;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Time.timeScale = 0f;
            Canvas.SetActive(true);
        }
    }

    public void ToMenuButton(){
        SceneManager.LoadScene(0);
    }

    public void ContinueButton(){
        Canvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
