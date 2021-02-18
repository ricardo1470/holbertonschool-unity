using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    //public Button RestartButton;

    [FormerlySerializedAs("PauseCanvas")] public GameObject pauseCanvas;
    
    public void Pause()
    {}

    private void Resume()
    {}

    public void Restart()
    {}
}
