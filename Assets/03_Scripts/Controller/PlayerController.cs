using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerPosY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosY = transform.position.y; // �÷��̾��� �ʱ� Y ��ġ�� ����
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //�÷��̾� ������ ����
            Debug.Log("playerPositionY"+ playerPosY);
            playerPosY = -playerPosY;     // Y ��ġ�� ����
            transform.position = new Vector3(transform.position.x, playerPosY, transform.position.z);
        }
    }
}
