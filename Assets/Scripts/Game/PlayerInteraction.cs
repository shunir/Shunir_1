using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    private bool canInteract = false;

    // Mini Game ������Ʈ�� �浹 ��
    private void OnTriggerEnter2D(Collider2D other) // 3D�� ��� OnTriggerEnter�� ����
    {
        if (other.CompareTag("minigame"))
        {
            canInteract = true;
            Debug.Log("�̴ϰ��� ������Ʈ ��ó�� �ֽ��ϴ�. FŰ�� ���� ��ȣ�ۿ��ϼ���.");
        }
    }

    // Mini Game ������Ʈ���� ��� ��
    private void OnTriggerExit2D(Collider2D other) // 3D�� ��� OnTriggerExit�� ����
    {
        if (other.CompareTag("minigam"))
        {
            canInteract = false;
            Debug.Log("�̴ϰ��� ������Ʈ���� ������ϴ�.");
        }
    }

    void Update()
    {
        // FŰ�� ������ ��ȣ�ۿ� ������ ������ ��
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("FŰ �Է� ����! �÷��ǹ��� ������ �̵��մϴ�.");
            SceneManager.LoadScene("FlappyPlane_Project"); // �÷��ǹ��� �� �̸����� ����
        }
    }
}