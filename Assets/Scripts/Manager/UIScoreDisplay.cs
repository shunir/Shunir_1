using UnityEngine;
using UnityEngine.UI;

public class MainSceneScoreDisplay : MonoBehaviour
{
    public Text scoreText; // UI Text 연결

    void Start()
    {
        // PlayerPrefs에서 점수 불러오기
        int score = PlayerPrefs.GetInt("LastScore", 0);
        scoreText.text = "지난 점수: " + score.ToString();
    }
}