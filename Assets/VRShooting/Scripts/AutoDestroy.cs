using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float lifetime = 5f; // ���� ������Ʈ�� ����

    // Start is called before the first frame update
    void Start()
    {
        // ���� �ð� ��� �Ŀ� ���� ������Ʈ�� �����Ѵ�.
        AutoDestroy(gameObject, lifetime);
    }
}
