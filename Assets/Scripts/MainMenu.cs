using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool _isLoading = false;

    public void OnStartGameButtonClick()
    {
        if (!_isLoading)
        {
            _isLoading = true;

            SceneManager.LoadScene("GameplayScene");
        }
    }
}
