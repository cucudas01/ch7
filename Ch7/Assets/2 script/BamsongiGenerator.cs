using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �� ��ũ��Ʈ�� ����� ������Ʈ�� ��ġ�� ������ �������� ����� ����
            Vector3 spawnPosition = transform.position + transform.forward * 1f; // ������Ʈ �� 1m ����
            Quaternion spawnRotation = transform.rotation; // ������Ʈ�� ȸ����

            // ����� ����
            GameObject bamsongi = Instantiate(bamsongiPrefab, spawnPosition, spawnRotation);

            // ������Ʈ�� ���� �������� �߻�
            Vector3 forwardDirection = transform.forward;
            bamsongi.GetComponent<BamsongiController>().Shoot(forwardDirection.normalized * 2000);
        }
    }
}