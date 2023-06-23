using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip; // ���� ���� AudioClip
    [SerializeField] AudioClip hitClip; // �Ѿ� ���� ���� AudioClip

    // �����߷��� �� ��ȿȭ�ϱ� ���ؼ� �ݶ��̴��� �������� ���� �ִ´�
    [SerializeField] Collider enemyCollider; // �ݶ��̴�

    AudioSource audioSource; // ����� ����ϴ� AudioSource

    void Start()
    {
        // AudioSource ������Ʈ�� ����� �д�.
        audioSource = GetComponent<AudioSource>();

        // ���� ���� �Ҹ��� ���
        audioSource.PlayOneShot(spawnClip); 
    }

    // OnHitMessage �޽����κ��� ȣ��Ǵ� ���� ����
    void OnHitBullet()
    {
        // �Ѿ� ���� ���� �Ҹ��� ���
        audioSource.PlayOneShot(hitClip);

        // �������� ���� ó��
        GoDown();
    }

    void GoDown()
    {
        // �浹 ������ ǥ�ø� �����
        enemyCollider.enabled = false;

        // �ڽ��� ���� ������Ʈ�� ���� �ð� �Ŀ� ����
        Destroy(gameObject, 0.3f);
    }
}
