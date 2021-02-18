using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public Button RestartButton;

    public GameObject PauseCanvas;
    
    public void Pause()
    {
        // value keyboard Esc
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseCanvas.SetActive(true);
        }
    }

    public void Resume()
    {}

    public void Restart()
    {}
}
