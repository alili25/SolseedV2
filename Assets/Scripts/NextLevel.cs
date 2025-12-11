using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
}
