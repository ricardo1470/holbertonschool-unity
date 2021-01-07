using System;
using System.Xml.Serialization;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    // speed
    public float speed;

    private Rigidbody rigid;

    // score
    private int score;

    // health
    public int health = 5;

    // score text
    public Text scoreText;

    // health text
    public Text healthText;

    // win text
    public Text WinLoseText;

    // UI object
    public Image WinLoseBG;

    // game object win lose
    public GameObject WinLoseObject;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody> ();
    }

    // functions to allow the Player to move when either
    // the WASD or arrow keys are pressed
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);

        rigid.AddForce (move * speed);
    }

    void OnTriggerEnter (Collider other)
    {
		if (other.tag == "Pickup")
        {
			score++;
			Destroy(other.gameObject);
            SetScoreText();
			// Debug.Log(string.Format("Score: {0}", score));
		}

        if (other.tag == "Trap")
        {
            health--;
            SetHealthText();
        }

        if (other.tag == "Goal")
        {
            You_win();
            //Debug.Log("You win!");
        }

    }

    void Update()
    {
        if (health == 0)
        {
            Game_Over();
            //Debug.Log("Game Over!");
        }

        // value keyboard Esc
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }

    void SetScoreText()
    {
        //scoreText.text = (string.Format("Score: {0}", score));
        scoreText.text = $"Score: {score}";
    }

    void SetHealthText()
    {
        healthText.text = $"Health: {health}";
    }

    void You_win()
    {
        WinLoseText.text = "You Win!";
        WinLoseText.color = Color.black;
        WinLoseBG.color = Color.green;
        WinLoseObject.SetActive(true);
        StartCoroutine(LoadScene(3));
    }

    void Game_Over()
    {
        WinLoseText.text = "Game Over!";
        WinLoseText.color = Color.white;
        WinLoseBG.color = Color.red;
        WinLoseObject.SetActive(true);
        StartCoroutine(LoadScene(3));
    }

    IEnumerator LoadScene(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
