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

    // ������Ʈ ���̽� Ŭ����
    abstract class BaseState
    {
        public GameStateController Controller { get; set; }

        public enum StateAction
        {
            STATE_ACTION_WAIT,
            STATE_ACTION_NEXT
        }

        public BaseState(GameStateController c) { Controller = c; }

        public virtual void OnEnter() { }
        public virtual StateAction OnUpdate() { return StateAction.STATE_ACTION_NEXT; }
        public virtual void onExit() { }
    }

}
