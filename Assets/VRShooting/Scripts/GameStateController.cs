using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    [SerializeField] GameObject gameReady; // GameReady 게임 오브젝트 참조
    [SerializeField] RemainTimer timer; // RemainTimer 게임 오브젝트 참조
    [SerializeField] GameObject gameStart; // GameStart 게임 오브젝트 참조
    [SerializeField] GameObject gameOver; // GameOver 게임 오브젝트 참조
    [SerializeField] GameObject result; // Result 게임 오브젝트 참조
    [SerializeField] GameObject player; // PlayerGun 게임 오브젝트 참조
    [SerializeField] GameObject spawners; // Spawner 게임 오브젝트 참조
}
