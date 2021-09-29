using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour
{
    static string TagRock = "rock";
    static string TagPaper = "paper";  
    static string TagScissors = "scissors";
    public GameObject player1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (((other.tag == "paper") && (tag == "scissors")) || ((other.tag == "scissors") && (tag == "rock")) || ((other.tag == "rock") && (tag == "paper")))
        {
            Destroy(other);
        }
    }
}
