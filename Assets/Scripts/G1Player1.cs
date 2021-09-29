using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G1Player1 : MonoBehaviour
{

    private bool shoot;
    private float speed = 3;

    public GameObject bullet;
    public Vector3 bulletOffset; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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

        if (Input.GetKeyDown(KeyCode.E) && shoot == false)
        {
            shoot = true;
            Instantiate(bullet, transform.position + bulletOffset, transform.rotation);
            StartCoroutine(WaitShoot());
        }
    }

    IEnumerator WaitShoot()
    {
        yield return new WaitForSeconds(2f);
        shoot = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BulletP2")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            //GameplayManager.Instance.ShowGameOver();
        }
    }

}
