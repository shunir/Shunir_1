using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    public void OnGameOver()
    {
        // ���� ���� ���� (����)
        // PlayerPrefs.SetInt("LastScore", score);

        // �� �̵�
        SceneManager.LoadScene("MainScene");
    }
}

