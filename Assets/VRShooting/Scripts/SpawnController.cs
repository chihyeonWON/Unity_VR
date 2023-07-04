using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3f; // 적 출현 간

    EnemySpawner[] spawners; // EnemySpawner의 리스트
    float timer = 0f;        // 출현 시간 판정용의 타이머 변수

    // Use this for initialization
    void Start()
    {
        // 자식 오브젝트에 존재하는 EnemySpawner 리스트를 취득
        spawners = GetComponentsInChildren<EnemySpawner>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(spawnInterval < timer)
        {
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();

            timer = 0f;
        }
    }
}
