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
            Debug.LogError("GameManager.Instance�� null�Դϴ�. ���� ���� ������ ������ �� �����ϴ�.");
            SceneManager.LoadScene("FlappyPlane_Project");
        }
    }
}

