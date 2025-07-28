using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCInteraction : MonoBehaviour
{
    private bool isNear = false;

    void Update()
    {
        if (isNear && Input.GetKeyDown(KeyCode.F))
        {
            // �̴ϰ��� ���� �� ������ �ʱ�ȭ (���� ��)
            MINIGameData.GameData.LastScore = 0;

            // �̴ϰ��� ������ �̵�
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
