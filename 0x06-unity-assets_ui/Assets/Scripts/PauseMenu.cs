using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    //public Button RestartButton;

    public GameObject pauseCanvas;
    bool paused = false;
    public Button ResumeButton;

    public void Start()
    {
        ResumeButton.onClick.AddListener(delegate
        {
            pauseCanvas.SetActive(false);
            Resume();
        });
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        paused = true;
    }

    private void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        paused = false;
    }

    public void Restart()
    {}
}
