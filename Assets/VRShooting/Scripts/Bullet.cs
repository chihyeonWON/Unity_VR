using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f; // �Ѿ� �ӵ� [m/s]

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ ���� ������ �ӵ� ���͸� ���
        var velocity = speed * transform.forward;

        // Rigidbody ������Ʈ�� ���
        var rigidbody = GetComponent<Rigidbody>();

        // Rigidbody ������Ʈ�� ����� ���� �ӵ��� �ش�
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    // Ʈ���� ���� ���� �ÿ� ȣ��ȴ�.
    void onTriggerEnter(Collider other)
    {
        // �浹 ��� "OnHitBullet" �޽���
        other.SendMessage("OnHitBullet");

        // �ڽ��� ���� ������Ʈ�� ����
        Destroy(gameObject);
    }
}
