using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public ColumFactory Factory;
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private GameOverMenu _gameOverMenu;
    private float frequence;

    private void SetFrequence()
    {
        frequence = Random.Range(1f, 3f);//
    }


    void Start()
    {
        _mainMenu.ShowWindow();
        PauseController.StopGame();
        
        _gameOverMenu.HideWindow(); //
        
        SetFrequence(); // Понял что установка какогто значения
        InvokeRepeating(nameof(SpawnColum), 0f, frequence);// Не понял что это
    }

    private void SpawnColum()
    {
        SetFrequence();
        Factory.Create(); // Сохдали переменую с именем Factory
    }
}