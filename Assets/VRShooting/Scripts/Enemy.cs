using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip; // ���� ���� AudioClip
    [SerializeField] AudioClip hitClip; // �Ѿ� ���� ���� AudioClip

    // �����߷��� �� ��ȿȭ�ϱ� ���ؼ� �ݶ��̴��� ���� �ִ´�
    [SerializeField] Collider enemyCollider; // �ݶ��̴�
    [SerializeField] Renderer enemyRenderer; // ������

    AudioSource audioSource; // ����� ����ϴ� AudioSource

    [SerializeField] int point = 1;
    Score score;

    void Start()
    {
        // AudioSource ������Ʈ�� ����� �д�.
        audioSource = GetComponent<AudioSource>();

        // ���� ���� �Ҹ��� ���
        audioSource.PlayOneShot(spawnClip);

        // ���� ������Ʈ�� �˻�
        var gameObj = GameObject.FindWithTag("Score");

        // gameObj�� ���ԵǴ� Score ������Ʈ�� ���
        score = gameObj.GetComponent<Score>();
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
        // ������ ����
        score.AddScore(point);

        // �浹 ������ ǥ�ø� �����
        enemyCollider.enabled = false;

        // �ڽ��� ���� ������Ʈ�� ���� �ð� �Ŀ� ����
        Destroy(gameObject, 0.4f);
    }
}
