using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    [SerializeField] GameObject gameReady; // GameReady ���� ������Ʈ ����
    [SerializeField] RemainTimer timer; // RemainTimer ���� ������Ʈ ����
    [SerializeField] GameObject gameStart; // GameStart ���� ������Ʈ ����
    [SerializeField] GameObject gameOver; // GameOver ���� ������Ʈ ����
    [SerializeField] GameObject result; // Result ���� ������Ʈ ����
    [SerializeField] GameObject player; // PlayerGun ���� ������Ʈ ����
    [SerializeField] GameObject spawners; // Spawner ���� ������Ʈ ����
}
