using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _playGameButton;

    private void Start()
    {
        _playGameButton.onClick.AddListener(OnPlayGameButtonClicked);
    }

    private void OnPlayGameButtonClicked()
    {
        HideWindow();

        PauseController.ResumeGame(); 
    }

    public void ShowWindow()
    {
        gameObject.SetActive(true);
    }

    public void HideWindow()
    {
       gameObject.SetActive(false); 
    }
    
    
    
}