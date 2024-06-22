using System;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
       [SerializeField] private Button _playGameButton;

    
    
    private void OpenGame()
    {
        _playGameButton.gameObject.SetActive(true);
   }

    private void CloseGameMenu()
    {
        gameObject.SetActive(false);
        
        Time.timeScale = 0f;
        
    }

    private void Start()
    { 
      _playGameButton.onClick.AddListener(CloseGameMenu);
    }

    void OnPlayGameButtonClicked() 
  {
        gameObject.SetActive(false);
   }

    
   }