using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ARSceneChanger : MonoBehaviour
{
    public string sceneToLoad;
    public StageManager_Library stageManager;

    private void Start()
    {
        var observer = GetComponent<ObserverBehaviour>();
        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if ((status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED) && !hasTriggered)
        {
            hasTriggered = true;
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    private bool hasTriggered = false; // 중복 방지
}
