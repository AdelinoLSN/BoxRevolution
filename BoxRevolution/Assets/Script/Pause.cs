using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pause_panel;

    void Start()
    {
        OnUnPause();   
    }

    void Update()
    {
        bool pause = Input.GetButtonDown("Cancel");

        if (pause)
        {
            OnPause();
        }
    }

    public void OnPause()
    {
        pause_panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void OnUnPause()
    {
        pause_panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
