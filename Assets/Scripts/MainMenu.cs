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
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}