using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // OnHitMessage �޽����κ��� ȣ��Ǵ� ���� ����
    void OnHitMessage()
    {
        // �ڽ��� ���� ������Ʈ�� ����
        Destroy(gameObject);
    }
}
