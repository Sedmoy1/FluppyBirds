using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public ColumFactory Factory;
    [SerializeField] private MainMenu _mainMenu;

    private float frequence;

    private void SetFrequence()
    {
        frequence = Random.Range(1f, 3f);
    }


    void Start()
    {
        _mainMenu.ShowWindow();
        PauseController.StopGame();
        SetFrequence();
        InvokeRepeating(nameof(SpawnColum), 0f, frequence);
    }

    private void SpawnColum()
    {
        SetFrequence();
        Factory.Create();
    }
}