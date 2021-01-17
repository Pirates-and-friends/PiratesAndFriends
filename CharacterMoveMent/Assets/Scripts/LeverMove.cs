using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverMove : MonoBehaviour
{
    public bool isMove = false;
    public bool isSet = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isSet && Input.GetKeyDown(KeyCode.X))
        {
            isMove = !isMove;
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.tag);

        if(other.tag == "Player")
        {
            isSet = true;
        }
    }

    public void OnTriggerExit()
    {
        isSet = false;
    }
}
