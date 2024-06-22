using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColumCollision : MonoBehaviour
{
   // public AudioSource Sound1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 0f;
           
          //  Sound1.Play();
          ScoreApplicator.Score = 0;
        }
    }
    
    public void SetAudioSource(AudioSource source)
    {
  //      Sound1 = source;
    }

   
    
    public void BirhdayCake(int a , int  b , int c)
    {
        Console.ReadLine();
        c = a + b;


    }
}
