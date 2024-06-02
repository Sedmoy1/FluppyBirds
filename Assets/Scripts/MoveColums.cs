using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class MoveColums : MonoBehaviour
{
    public float Speed = 5;

    public ColumCollision UpCollision;
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
        UpCollision.SetAudioSource(sound1);
        DownCollision.SetAudioSource(sound1);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed);
        if (isRelease)
        {
            return;
        }

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            isRelease = true;
            OnRelease.Invoke(this);
        }
    }
}