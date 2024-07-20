using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class MoveColums : MonoBehaviour // пУБЛИЧНЫЙ КЛАСС
{
    public float Speed = 5;

    public ColumCollision UpCollision; //дОБАВЛЕННИЕ кОЛЛИЗИИ
    public ColumCollision DownCollision;
    public Action<MoveColums> OnRelease;

    private float timer;

    private bool isRelease = true;


    public void SetTimer(float timerAmount)
    {
        timer = timerAmount;

        isRelease = false;
    }


    public void SetAudioSource(AudioSource sound1)
    {
     
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);// Понял что это,не понятны ыекторы
        if (isRelease)
        {
            return;
        }

        timer -= Time.deltaTime;// Отнимается Время от переменной timer
        if (timer < 0)
        {
            isRelease = true;//
            OnRelease.Invoke(this);//
        }
    }
}