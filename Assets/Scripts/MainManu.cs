using System;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
       [SerializeField] private Button _playGameButton;
    public Button CloseStorageWindowButton;

    
    
    private void OpenGame()
    {
        _playGameButton.gameObject.SetActive(true);
   }

    private void CloseGameMenu()
    {
        gameObject.SetActive(false);
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