using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G3Player : MonoBehaviour
{
    public float player;
    private float speed = 3;
    private float halfPlayerSizeX;
    private float halfPlayerSizeY;

    public float life = 1;


    // Start is called before the first frame update
    void Start()
    {
        halfPlayerSizeX = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        halfPlayerSizeY = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == 1)
        {
            if (Input.GetKey("z"))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }

            if (Input.GetKey("q"))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        if (player == 2)
        {
            if (Input.GetKey("up"))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            if (Input.GetKey("down"))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }

            if (Input.GetKey("left"))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (Input.GetKey("right"))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        clampPlayerMovement();

    }
    void clampPlayerMovement()
    {
        Vector3 position = transform.position;

        float distance = transform.position.z - Camera.main.transform.position.z;

        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + halfPlayerSizeX;
        float rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0, distance)).x - halfPlayerSizeX;
        float downBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, -0.05f, distance)).y + halfPlayerSizeY;
        float upBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.95f, distance)).y - halfPlayerSizeY;

        position.x = Mathf.Clamp(position.x, leftBorder, rightBorder);
        position.y = Mathf.Clamp(position.y, downBorder, upBorder);
        transform.position = position;
    }
}
