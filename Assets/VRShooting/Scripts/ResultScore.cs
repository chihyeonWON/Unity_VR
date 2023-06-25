using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ResultScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ�� �˻�
        var gameObj = GameObject.FindWithTag("Score");

        // gameObj�� ���ԵǴ� Score ������Ʈ�� ���
        var score = gameObj.GetComponent<Score>();

        // Text ������Ʈ�� ���
        var uiText = GetComponent<Text>();

        // ���� ����
        uiText.text = string.Format("���� : {0:D3}��", score.Points);
    }
}
