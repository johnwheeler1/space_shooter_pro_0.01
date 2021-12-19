﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Variables
    [Header("Player Score")]
    [SerializeField] private Text _scoreText;
    [Header("Player Lives")]
    [SerializeField] private Image _LivesImg;
    [SerializeField] private Sprite[] _liveSprites;
    
    void Start()
    {
        _scoreText.text = "Score: " + 0;
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Score: " + playerScore.ToString();
    }

    public void UpdateLives(int currentLives)
    {
        _LivesImg.sprite = _liveSprites[currentLives];
    }
}