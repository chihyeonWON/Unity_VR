using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class SlideInOut : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        // rectTranform ������Ʈ ���
        var rectTransform = GetComponent<RectTransform>();

        // DOTween�� �������� �ۼ�
        var sequence = DOTween.Sequence();

        // ȭ�� �����ʿ��� �����̵����Ѵ�.
        sequence.Append(rectTransform.DOMoveX(0.0f, 1.0f));

        // ȭ�� �������� �����̵�ƿ��Ѵ�.
        sequence.Append(rectTransform.DOMoveX(-1400.0f, 0.8f));
    }
}
