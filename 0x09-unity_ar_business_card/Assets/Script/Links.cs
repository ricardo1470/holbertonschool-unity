using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void linkGitHub()
    {
        Application.OpenURL("https://github.com/ricardo1470");
    }

    public void linkLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/ricardo-alfonso-camayo/");
    }

    public void linkTelegram()
    {
        Application.OpenURL("https://t.me/ricardo1470");
    }

    public void linkTwitter()
    {
        Application.OpenURL("https://twitter.com/RICARDO1470");
    }

    public void linkemail()
    {
        string email = "ricardo.alfonso.camayo@gmail.com";
        string subject = MyEscapeURL("My Subject");
        string body = MyEscapeURL("My Body\r\nFull of non-escaped chars");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
