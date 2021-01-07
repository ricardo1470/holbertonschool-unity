using System.Net.Mime;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // button play
    public Button playButton;

    // button Quit
    public Button QuitButton;

    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        QuitButton.onClick.AddListener(QuitMaze);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // load maze scene
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");

        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
    }

    // method should close the game window
    // when the Quit button is pressed.
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
