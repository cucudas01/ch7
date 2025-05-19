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
            Debug.LogWarning("Player ������Ʈ�� ã�� �� �����ϴ�.");
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
        // Bamsongi ��ũ��Ʈ�� ���� ������Ʈ�� �¾Ҵ��� Ȯ��
        if (collision.gameObject.GetComponent<bamsongi>() != null)
        {
            Destroy(gameObject);
        }
    }
}
