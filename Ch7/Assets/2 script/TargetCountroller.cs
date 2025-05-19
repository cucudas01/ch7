using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCountroller : MonoBehaviour
{
    Transform Player;
    Transfrom bamsongi;
    void Start()
    {
        GameObject playerObj = GameObject.Find("Player");
        if (playerObj != null)
        {
            Player = playerObj.transform;
        }
        else
        {
            Debug.LogWarning("Player 오브젝트를 찾을 수 없습니다.");
        }
    }

    void Update()
    {
        if (Player != null)
        {
            transform.LookAt(Player);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Bamsongi 스크립트가 붙은 오브젝트에 맞았는지 확인
        if (collision.gameObject.GetComponent<bamsongi>() != null)
        {
            Destroy(gameObject);
        }
    }
}
