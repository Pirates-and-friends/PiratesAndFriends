using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 플레이어의 입력을 받는 코드
 */

public class PlayerInput : MonoBehaviour
{
    string GetHorizontal = "Horizontal";
    
    
    [Header("조작 관련 입력 변수")]
    public float move;          //이동

    public bool jump,jumpoff;   //점프
    public bool dash, dashoff;  //대쉬

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis(GetHorizontal); // 좌, 우 화살표, a d

        jump = Input.GetKeyDown(KeyCode.Space); // GetButton Down : bool( 참 / 거짓 ) 값 반환
        jumpoff = Input.GetKeyUp(KeyCode.Space);

        dash = Input.GetKeyDown(KeyCode.Z);
        dashoff = Input.GetKeyUp(KeyCode.Z);
    }
}
