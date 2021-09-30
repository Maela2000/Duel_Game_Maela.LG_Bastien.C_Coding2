using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManagerG1 : MonoBehaviour
{
    public static GameplayManagerG1 Instance;

    public float timeRemaining = 30;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject equalityPanel;
    public GameObject victoryplayer1;
    public GameObject victoryplayer2;

    public GameObject shootplayer1;
    public GameObject shootplayer2;


    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = string.Format("{0:00}", timeRemaining);
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                StartCoroutine(WaitEquality());
            }
        }
    
        if(player1.GetComponent<G1Player1>().life==0)
        {
            VictoryPlayer2();
        }

        if (player2.GetComponent<G1Player2>().life == 0)
        {
            VictoryPlayer1();
        }

        if (player1.GetComponent<G1Player1>().shoot==false)
        {
            shootplayer1.SetActive(true);
        }
        else { shootplayer1.SetActive(false); }

        if (player2.GetComponent<G1Player2>().shoot == false)
        {
            shootplayer2.SetActive(true);
        }

        else { shootplayer2.SetActive(false); }
    }

    IEnumerator WaitEquality()
    {
        if (player2.GetComponent<G1Player2>().life != 0 && player1.GetComponent<G1Player1>().life != 0)
        {
            yield return new WaitForSeconds(0.25f);
            equalityPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void VictoryPlayer1()
    {
        Time.timeScale = 0f;
        victoryplayer1.SetActive(true);
    }
    public void VictoryPlayer2()
    {
        Time.timeScale = 0f;
        victoryplayer2.SetActive(true);
    }
    public void OnClick_Retry()
    {
        SceneManager.LoadScene(1); //Go to scene 1
    }
    public void OnClick_Menu()
    {
        SceneManager.LoadScene(0); //Go to menu
    }
}
