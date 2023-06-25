using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip; // 출현 시의 AudioClip
    [SerializeField] AudioClip hitClip; // 총알 명중 시의 AudioClip

    // 쓰러뜨렸을 때 무효화하기 위해서 콜라이더를 갖고 있는다
    [SerializeField] Collider enemyCollider; // 콜라이더
    [SerializeField] Renderer enemyRenderer; // 렌더러

    AudioSource audioSource; // 재생에 사용하는 AudioSource

    [SerializeField] int point = 1;
    Score score;

    void Start()
    {
        // AudioSource 컴포넌트를 취득해 둔다.
        audioSource = GetComponent<AudioSource>();

        // 출현 시의 소리를 재생
        audioSource.PlayOneShot(spawnClip);

        // 게임 오브젝트를 검색
        var gameObj = GameObject.FindWithTag("Score");

        // gameObj에 포함되는 Score 컴포넌트를 취득
        score = gameObj.GetComponent<Score>();
    }

    // OnHitMessage 메시지로부터 호출되는 것을 상정
    void OnHitBullet()
    {
        // 총알 명중 시의 소리를 재생
        audioSource.PlayOneShot(hitClip);

        // 쓰러졌을 때의 처리
        GoDown();
    }

    void GoDown()
    {
        // 점수를 더함
        score.AddScore(point);

        // 충돌 판정과 표시를 지운다
        enemyCollider.enabled = false;

        // 자신의 게임 오브젝트를 일정 시간 후에 제거
        Destroy(gameObject, 0.4f);
    }
}
