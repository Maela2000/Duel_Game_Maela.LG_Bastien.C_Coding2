using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_2 : MonoBehaviour
{
    static string TagRock = "rock";
    static string TagPaper = "paper";
    static string TagScissors = "scissors";
    public GameObject player2;
    public float speed;  
    
        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed);
        if (Input.GetKeyDown("left"))
        {
            player2.tag = TagRock;                                 
        }
        if (Input.GetKeyDown("down"))
        {
            player2.tag = TagPaper;
        }
        if (Input.GetKeyDown("right"))
        {
            player2.tag = TagScissors;
        }
    }
}
