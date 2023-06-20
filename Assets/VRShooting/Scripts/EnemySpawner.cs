using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefab; // ������Ű���� ���� ������

    Enemy enemy; // ���� ���� ���� ����

    public void Spawn()
    {
        // ���� ���� �ƴϸ� ���� ������Ų��.
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}
