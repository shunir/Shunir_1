using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCInteraction : MonoBehaviour
{
    private bool isNear = false;

    void Update()
    {
        if (isNear && Input.GetKeyDown(KeyCode.F))
        {
            // 미니게임 시작 전 데이터 초기화 (점수 등)
            MINIGameData.GameData.LastScore = 0;

            // 미니게임 씬으로 이동
            SceneManager.LoadScene("FlappyBirdScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isNear = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isNear = false;
    }
}
