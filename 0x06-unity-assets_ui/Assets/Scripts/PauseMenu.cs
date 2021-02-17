using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour
{
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Pause()
    {
        // value keyboard Esc
        if (Input.GetKey(KeyCode.Escape))
        {
            //PauseCanvas.SetActive(true);
        }
    }

    public void Resume()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //PauseCanvas.SetActive(true);
        }
    }

    public void Restart()
    {}
}
