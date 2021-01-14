using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBlockMove : MonoBehaviour
{
    public GameObject pairLever;
    LeverMove leverMove;

    Vector3 startPosition;

    float speed = 1f;
    float maxMove = 3f;
    bool isBlockMove = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        leverMove = pairLever.GetComponent<LeverMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if(leverMove.isMove)
        {
            isBlockMove = true;
        }

        if(isBlockMove)
        {
            Move();
        }
    }

    void Move()
    {
        transform.position += Vector3.up * speed;
        if (transform.position.y > startPosition.y + maxMove)
            isBlockMove = false;
    }
}
