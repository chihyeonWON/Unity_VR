using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    Text uiText; // UIText ������Ʈ

    public int Points { get; private set; } // ������ ���� ����Ʈ

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    public void AddScore(int addPoint)
    {
        // ������ ����Ʈ�� ����
        Points += addPoint;

        // ���� ����
        uiText.text = string.Format("���� : {0:D3}��", Points);
    }
}

