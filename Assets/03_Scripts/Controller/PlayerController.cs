using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerPosY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosY = transform.position.y; // 플레이어의 초기 Y 위치를 저장
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //플레이어 포지션 변경
            Debug.Log("playerPositionY"+ playerPosY);
            playerPosY = -playerPosY;     // Y 위치를 반전
            transform.position = new Vector3(transform.position.x, playerPosY, transform.position.z);
        }
    }
}
