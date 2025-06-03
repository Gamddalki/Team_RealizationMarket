using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;

    public AudioSource bgmSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            float savedVolume = PlayerPrefs.GetFloat("BGMVolume", 0.5f);
            bgmSource.volume = savedVolume;
        }
        else
        {
            Destroy(gameObject); // 중복 방지
        }
    }

    public void SetVolume(float volume)
    {
        bgmSource.volume = volume;
        PlayerPrefs.SetFloat("BGMVolume", volume);
        PlayerPrefs.Save();
    }
}
