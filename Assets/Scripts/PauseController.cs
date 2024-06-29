using UnityEngine;

public static class PauseController
{
    public static void ResumeGame()
    {
        Time.timeScale = 1f;
    }
    
    public static void StopGame()
    {
        Time.timeScale = 0f;
    }
    
    
}