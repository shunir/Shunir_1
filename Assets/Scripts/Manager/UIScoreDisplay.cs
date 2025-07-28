using UnityEngine;
using UnityEngine.UI;

public class MainSceneScoreDisplay : MonoBehaviour
{
    public Text scoreText; // UI Text ����

    void Start()
    {
        // PlayerPrefs���� ���� �ҷ�����
        int score = PlayerPrefs.GetInt("LastScore", 0);
        scoreText.text = "���� ����: " + score.ToString();
    }
}