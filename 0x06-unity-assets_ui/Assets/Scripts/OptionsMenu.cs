using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class OptionsMenu : MonoBehaviour
{
    // return button
    public Button BackButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // function to return to the previous menu
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
