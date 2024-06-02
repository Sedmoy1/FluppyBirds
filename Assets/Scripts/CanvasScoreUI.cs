using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasScoreUI : MonoBehaviour
{

    public TextMeshProUGUI Score;
    
    

        // Update is called once per frame
    void Update()
    {
        Score.text = ScoreApplicator.Score.ToString();
    }
}
