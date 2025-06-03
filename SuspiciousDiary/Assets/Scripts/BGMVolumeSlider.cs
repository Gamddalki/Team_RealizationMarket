using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMVolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // 이전 설정값 불러오기
        if (volumeSlider != null)
        {
            volumeSlider.value = PlayerPrefs.GetFloat("BGMVolume", 1f);
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
        }
    }

    public void OnVolumeChanged(float value)
    {
        if (BGMManager.Instance != null)
            BGMManager.Instance.SetVolume(value);
    }
}
