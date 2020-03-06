﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMPro.TextMeshProUGUI playButton;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("entering UIobject");
        playButton.fontStyle = TMPro.FontStyles.Underline;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        playButton.fontStyle = TMPro.FontStyles.Normal;
    }
}
