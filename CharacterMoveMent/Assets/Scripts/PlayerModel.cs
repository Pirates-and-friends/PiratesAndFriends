using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 플레이어의 스탯을 받아오는 코드
 */

// 상속이 필요한 경우 상속 수행 , MonoBehaviour를 상속할 필요는 없음.
public class PlayerModel : MonoBehaviour
{
    [Header("이동 관련")]
    public float speed = 5f;
    public float jumpPower = 7f;
    public Vector3 playerVelocity;

    public int jumpCnt = 2; // 연속 2단점프 제한
    public int dashCnt = 4; // 연속 4단대쉬 제한

    [Header("동작상태 관련")]
    public bool isGrounded = false;
    public bool isJump = false;
    public bool isDash = false;
    public bool isLookRight = true;
}
