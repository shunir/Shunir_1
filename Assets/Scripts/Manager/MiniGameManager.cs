using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public void EndMiniGame()
    {

        if (GameManager.Instance != null)
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            Debug.LogError("GameManager.Instance가 null입니다. 게임 종료 로직을 실행할 수 없습니다.");
            SceneManager.LoadScene("FlappyPlane_Project");
        }
    }
}

