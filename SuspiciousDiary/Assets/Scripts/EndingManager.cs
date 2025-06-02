using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public GameObject currentImage;  // 클릭되는 이미지 (비활성화할 대상)
    public GameObject nextImage;     // 활성화할 이미지

    public void OnImageClick()
    {
        currentImage.SetActive(false);
        nextImage.SetActive(true);
    }
}
