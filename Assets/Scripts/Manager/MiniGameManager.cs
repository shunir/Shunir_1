using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    public void EndMiniGame()
    {
        ScoreManager.Save(); //점수 저장
        SceneManager.LoadScene("FlappyPlane_Project"); // 메인 씬으로 이동
    }
}

