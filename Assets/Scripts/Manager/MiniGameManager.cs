using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public void EndMiniGame()
    {
        ScoreManager.Save(); //���� ����
        SceneManager.LoadScene("FlappyPlane_Project"); // ���� ������ �̵�
    }
}

