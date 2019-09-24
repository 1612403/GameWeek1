using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    Vector2 newPos;
    public float speed = 0.05f;
    public bool moveLeft;
    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;
        moveLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 7.5)
            moveLeft = true;
        if (transform.position.x <= 4.0)
            moveLeft = false;
        if (moveLeft)
        {
            newPos.x -= speed;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else 
        {
            newPos.x += speed;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        transform.position = newPos;
    }
}
