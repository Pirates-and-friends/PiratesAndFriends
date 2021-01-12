using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    
    PlayerModel playerModel; // 시작할때 player의 playerModel 컴포넌트를 받아온다.

    // Start is called before the first frame update
    void Start()
    {
        playerModel = player.GetComponent<PlayerModel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
