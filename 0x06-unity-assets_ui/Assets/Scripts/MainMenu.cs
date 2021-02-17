using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{
    // level1 button
    public Button Level01;
    // level2 button
    public Button Level02;
    // level3 button
    public Button Level03;
    // options button
    public Button OptionsButton;
    // exit button
    public Button ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        Level01.onClick.AddListener(delegate {LevelSelect(0); });
		Level02.onClick.AddListener(delegate {LevelSelect(1); });
		Level03.onClick.AddListener(delegate {LevelSelect(2); });
        OptionsButton.onClick.AddListener(delegate {LevelSelect(4); });
        ExitButton.onClick.AddListener(() => ExitPlatforns());
    }
    // Update is called once per frame
    void Update()
    {
    }

    // function that loads the different levels
    public void LevelSelect(int level)
    {

        SceneManager.LoadScene(level);
    }

    // method that loads the options
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    // method should close the game window
    // when the Quit button is pressed.
    public void ExitPlatforns()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
