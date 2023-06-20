using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] float spawnInterval = 3f; // �� ���� ����

    EnemySpawner[] spawners; // EnemySpawner�� ����Ʈ
    float timer = 0f; // ���� �ð� �������� Ÿ�̸� ����

    // Start is called before the first frame update
    void Start()
    {
        // �ڽ� ������Ʈ�� �����ϴ� EnemySpawner ����Ʈ�� ���
        spawners = GetComponentsInChildren<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ÿ�̸� ����
        timer += Time.deltaTime;

        // ���� ������ ����
        if(spawnInterval < timer)
        {
            // �������� EnemySpawner�� �����ؼ� ���� ������Ų��
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();

            // Ÿ�̸� ����
            timer = 0f;
        }
    }
}
