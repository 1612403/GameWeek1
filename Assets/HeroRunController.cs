using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRunController : MonoBehaviour
{
    Vector2 newPos;

    public float speed = 0.025f;
    public float jump = 250.0f;

    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetTrigger("Run");
            newPos.x -= speed;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetTrigger("Run");
            newPos.x += speed;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.position = newPos;
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
        }*/
    }
}
