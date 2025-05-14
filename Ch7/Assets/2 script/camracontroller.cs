using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camracontroller : MonoBehaviour
{
    public Transform target; // 따라갈 대상
    public Vector3 offset;   // 카메라와 대상 간의 거리
    public float smoothSpeed = 0.125f; // 부드러운 이동 속도

    void LateUpdate()
    {
        if (target != null)
        {
            // 목표 위치 계산
            Vector3 desiredPosition = target.position + offset;

            // 부드럽게 이동
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // 대상 바라보기 (선택 사항)
            transform.LookAt(target);
        }
    }
}