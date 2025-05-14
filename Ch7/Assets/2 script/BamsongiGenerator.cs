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
            // 이 스크립트가 적용된 오브젝트의 위치와 방향을 기준으로 밤송이 생성
            Vector3 spawnPosition = transform.position + transform.forward * 1f; // 오브젝트 앞 1m 지점
            Quaternion spawnRotation = transform.rotation; // 오브젝트의 회전값

            // 밤송이 생성
            GameObject bamsongi = Instantiate(bamsongiPrefab, spawnPosition, spawnRotation);

            // 오브젝트의 정면 방향으로 발사
            Vector3 forwardDirection = transform.forward;
            bamsongi.GetComponent<BamsongiController>().Shoot(forwardDirection.normalized * 2000);
        }
    }
}