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
    float direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        leverMove = pairLever.GetComponent<LeverMove>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(leverMove.isMove);
        if(leverMove.isMove)
        {
            Move();
        }
    }

    void Move()
    {
        transform.position += Vector3.right * speed*Time.deltaTime * direction;
        if (transform.position.x > startPosition.x + maxMove)
            direction = -1;
        if (transform.position.x < startPosition.x)
            direction = 1;
    }
}