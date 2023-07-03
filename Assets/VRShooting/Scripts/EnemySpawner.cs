using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy[] enemyPrefabs; // ������Ű���� ���� ������

    Enemy enemy; // ���� ���� ���� ����

    public void Spawn()
    {
        // ���� ���� �ƴϸ� ���� ������Ų��.
        if(enemy == null)
        {
            // ��ϵǾ� �ִ� ���� �����տ��� �ϳ��� �������� ����
            var index = Random.Range(0, enemyPrefabs.Length);

            // ������ ���� �ν��Ͻ��� �ۼ�
            enemy = Instantiate(enemyPrefabs[index], transform.position, transform.rotation);
        }
    }
}
