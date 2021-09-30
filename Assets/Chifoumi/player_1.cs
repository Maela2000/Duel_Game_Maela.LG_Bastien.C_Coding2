using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour
{
    static string TagRock = "rock";
    static string TagPaper = "paper";  
    static string TagScissors = "scissors";
    public GameObject player1;
    public float speed;
    public int res;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);

        if (Input.GetKeyDown("q"))
        {
            player1.tag = TagRock;
        }
        if (Input.GetKeyDown("s"))
        {
            player1.tag = TagPaper;
        }
        if (Input.GetKeyDown("d"))
        {
            player1.tag = TagScissors;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (res == 1)
        {
            Destroy(other.gameObject);
        }
        else if (res == 2)
        {
            Destroy(gameObject);
        }
        else if (res == 0)
        {
            //Destroy(other.gameObject);
            //Destroy(gameObject);
        }
    }
    private void Result(string Tag1, string Tag2)
    {
        switch (Tag1)
        {
            case "paper":
                switch (Tag2)
                {
                    case "paper":
                        res = 0;
                        break;

                    case "rock":
                        res = 2;
                        break;

                    case "scissors":
                        res = 1;
                        break;

                }
                break;

            case "rock":
                switch (Tag2)
                {
                    case "paper":
                        res = 2;
                        break;

                    case "rock":
                        res = 0;
                        break;

                    case "scissors":
                        res = 1;
                        break;

                }
                break;

            case "scissors":
                switch (Tag2)
                {
                    case "paper":
                        res = 1;
                        break;

                    case "rock":
                        res = 2;
                        break;

                    case "scissors":
                        res = 0;
                        break;
                }
                break;

        }
    }

}
