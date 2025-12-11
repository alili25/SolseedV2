using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneUI : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");  // ⚠️ Use exact scene name!
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenuScene"); // or whatever your gameplay scene is called
    }
}