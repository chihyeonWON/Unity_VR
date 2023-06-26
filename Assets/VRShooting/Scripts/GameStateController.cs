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

    // 스테이트 베이스 클래스
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

    // 게임 시작 준비 스테이트
    class ReadyState : BaseState
    {
        float timer;

        public ReadyState(GameStateController c) : base(c) { }
        public override void OnEnter()
        {
            // ready 문자열을 표시
            Controller.gameReady.SetActive(true);
        }
        public override StateAction OnUpdate()
        {
            timer += Time.deltaTime;
            // 5초 후에 다음으로
            if(timer > 5.0f)
            {
                return StateAction.STATE_ACTION_NEXT;
            }
            return StateAction.STATE_ACTION_WAIT;
        }
        public override void onExit()
        {
            // ready 문자열을 숨김
            Controller.gameReady.SetActive(false);
        }
    }
}
