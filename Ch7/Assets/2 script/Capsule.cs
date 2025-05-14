using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float moveSpeed = 1f; // �̵� �ӵ�
    public float rotationSpeed = 100f; // ȸ�� �ӵ�

    // Update�� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        // �Է� �� ��������
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // �̵� ó��
        Vector3 move = transform.forward * zInput * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // ȸ�� ó��
        float rotation = xInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}