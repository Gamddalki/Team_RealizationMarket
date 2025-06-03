using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;
    public string settingScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ChangeSettingScene()
    {
        // 현재 씬 이름 저장
        SceneMemory.previousSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(settingScene);
    }

    public void BackToPreviousScene()
    {
        if (!string.IsNullOrEmpty(SceneMemory.previousSceneName))
        {
            SceneManager.LoadScene(SceneMemory.previousSceneName);
        }
        else
        {
            Debug.LogWarning("이전 씬 정보가 없습니다. 기본 씬으로 이동합니다.");
            SceneManager.LoadScene("Intro"); // 또는 기본 대체 씬 이름
        }
    }
}
