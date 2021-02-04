using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // timer
    public Text TimerText;
	private float time = 0.00f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        time += Time.deltaTime;
		TimerText.text = string.Format("{1:0}:{0:00.00}", time % 60, time / 60);
    }

    public void TextWinColor()
    {
        enabled = false;
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
    }
}
