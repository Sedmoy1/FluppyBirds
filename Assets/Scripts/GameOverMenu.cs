using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour // Класс
{
    public Button RestartButton;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI LeaderScoreText;
    
    private  const string ScoreKey = "ScoreKey";
    
    public void Start()
    {
       
        RestartButton.onClick.AddListener(OnRestart);
    }

    private void OnRestart() //Метод По перезагрузки игры
    {
        SceneManager.LoadScene(0);
    }

    public void ShowWindow()
    {
        if(PlayerPrefs.HasKey(ScoreKey))
        {
            var leadersScore = PlayerPrefs.GetInt(ScoreKey);
            if (ScoreApplicator.Score > leadersScore)
            {
                SetNewLeader();
            }
            else
            {
                LeaderScoreText.text = $"Leader: {leadersScore.ToString()}";
            }
        }
        else
        {
            SetNewLeader();
        }
        
        gameObject.SetActive(true);
        ScoreText.text = $" Текущие очки игрока {ScoreApplicator.Score.ToString()}"; 
        ScoreApplicator.Score = 0;
    }

    private void SetNewLeader()
    {
        PlayerPrefs.SetInt(ScoreKey, ScoreApplicator.Score);
        PlayerPrefs.Save();

        LeaderScoreText.text = $"Leader: {ScoreApplicator.Score}";
    }

    public void HideWindow()// Прячет окно
    {
        gameObject.SetActive(false);
    }
    
}