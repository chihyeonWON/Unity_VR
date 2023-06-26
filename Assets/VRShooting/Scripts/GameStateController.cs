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

    // ���� ���� �غ� ������Ʈ
    class ReadyState : BaseState
    {
        float timer;

        public ReadyState(GameStateController c) : base(c) { }
        public override void OnEnter()
        {
            // ready ���ڿ��� ǥ��
            Controller.gameReady.SetActive(true);
        }
        public override StateAction OnUpdate()
        {
            timer += Time.deltaTime;
            // 5�� �Ŀ� ��������
            if(timer > 5.0f)
            {
                return StateAction.STATE_ACTION_NEXT;
            }
            return StateAction.STATE_ACTION_WAIT;
        }
        public override void onExit()
        {
            // ready ���ڿ��� ����
            Controller.gameReady.SetActive(false);
        }
    }

    class StartState : BaseState
    {
        float timer;

        public ReadyState(GameStateController c) : base(c) { }
        public override void OnEnter()
        {
            // Ÿ�̸Ӹ� ǥ��
            Controller.timer.gameObject.SetActive(true);

            // start ���ڿ��� ǥ��
            Controller.gameStart.SetActive(true);

            // player�� ǥ��
            Controller.player.SetActive(true);

            // spawners�� ǥ��
            Controller.spawners.SetActive(true);
        }
        public override StateAction OnUpdate()
        {
            timer += Time.deltaTime;
            // 1�� �Ŀ� ��������
            if (timer > 1.0f)
            {
                return StateAction.STATE_ACTION_NEXT;
            }
            return StateAction.STATE_ACTION_WAIT;
        }
        public override void onExit()
        {
            // start ���ڿ��� ����
            Controller.gameStart.SetActive(false);
        }
    }

    // ���� �� ������Ʈ
    class PlayingState : BaseState
    {
        public ReadyState(GameStateController c) : base(c) { }
        public override StateAction OnUpdate()
        {
            // Ÿ�̸Ӱ� �����ϸ� ���� ����
            if (!Controller.timer.IsCountingDown())
            {
                return StateAction.STATE_ACTION_NEXT;
            }
            return StateAction.STATE_ACTION_WAIT;
        }

        public override void onExit()
        {
            // �÷��̾ ����
            Controller.player.SetActive(false);

            // ���� �߻��� �����.
            Controller.spawners.SetActive(false);
        }
    }
}
