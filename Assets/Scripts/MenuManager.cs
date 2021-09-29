using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject rules;
    public GameObject crd;
    public GameObject levels;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick_Exit()//exit game
    {
        Application.Quit();
    }

    public void OnClick_Rules()  //Show game's rules
    {
        rules.SetActive(true);
    }

    public void OnClick_Credits() //Show credits
    {
        crd.SetActive(true);
    }

    public void OnClick_Levels()
    {
        levels.SetActive(true); //Active Levels panel
    }

    public void OnClick_Menu()
    {
        rules.SetActive(false);
        crd.SetActive(false);
        levels.SetActive(false);//disable Levels panel
    }
    public void OnClick_Game1()
    {
        SceneManager.LoadScene(1); //Go to scene 1
    }
}
