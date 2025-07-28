using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public void OnGameOver()
    {
        // 점수 저장 가능 (선택)
        // PlayerPrefs.SetInt("LastScore", score);

        // 씬 이동
        SceneManager.LoadScene("MainScene");
    }
}

