using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camracontroller : MonoBehaviour
{
    public Transform target; // ���� ���
    public Vector3 offset;   // ī�޶�� ��� ���� �Ÿ�
    public float smoothSpeed = 0.125f; // �ε巯�� �̵� �ӵ�

    void LateUpdate()
    {
        if (target != null)
        {
            // ��ǥ ��ġ ���
            Vector3 desiredPosition = target.position + offset;

            // �ε巴�� �̵�
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // ��� �ٶ󺸱� (���� ����)
            transform.LookAt(target);
        }
    }
}