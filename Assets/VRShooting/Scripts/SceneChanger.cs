using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ReloadScene()
    {
        // ������ ���� ���
        var scene = SceneManager.GetActiveScene();

        // ������ ���� �ٽ� �ε��Ѵ�.
        SceneManager.LoadScene(scene.name);
    }
}
