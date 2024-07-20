using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public GameOverMenu GameOverMenu;
    public Rigidbody2D Rigidbody;
    public float Force = 100f;
    
    private void OnTriggerEnter2D(Collider2D other) 
    { 
        if (other.CompareTag("Colum"))
        {
            PauseController.StopGame();// Стопит игру
            GameOverMenu.ShowWindow();
            

        }
    }
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector2.up * Force);// Вектор ум На скорость
        }
    }
}
