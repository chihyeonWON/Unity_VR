using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class RemainTimer : MonoBehaviour
{
    [SerializeField] float gameTime = 30.0f; // ���� ���� �ð� [��]
    Text uiText; // UIText ������Ʈ
    float currentTime; // ���� �ð� Ÿ�̸�

    // Start is called before the first frame update
    void Start()
    {
        // Text ������Ʈ ���
        uiText = GetComponent<Text>();

        // ���� �ð��� ����
        currentTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �ð��� ���
        currentTime -= Time.deltaTime;

        // 0�� ���Ϸδ� �ȵȴ�.
        if(currentTime <= 0.0f)
        {
            currentTime = 0.0f;
        }

        // ���� �ð� �ؽ�Ʈ ����
        uiText.text = string.Format("���� �ð� : {0:F} ��", currentTime);
    }

    // ī��Ʈ �ٿ��� �ϰ� �ִ� ��?
    public bool IsCountingDown()
    {
        // ī��Ʈ�� 0�� �ƴϸ� ī��Ʈ ��
        return currentTime > 0.0f;
    }
}
