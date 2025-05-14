using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float moveSpeed = 1f; // 이동 속도
    public float rotationSpeed = 100f; // 회전 속도

    // Update는 매 프레임마다 호출됩니다.
    void Update()
    {
        // 입력 값 가져오기
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // 이동 처리
        Vector3 move = transform.forward * zInput * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // 회전 처리
        float rotation = xInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}