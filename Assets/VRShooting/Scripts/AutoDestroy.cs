using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float lifetime = 5f; // 게임 오브젝트의 수명

    // Start is called before the first frame update
    void Start()
    {
        // 일정 시간 경과 후에 게임 오브젝트를 제거한다.
        AutoDestroy(gameObject, lifetime);
    }
}
