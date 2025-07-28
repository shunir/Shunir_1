using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    public PopupManager popupManager; // PopupManager ����

    void Start()
    {
        if (popupManager != null && GameManager.finalScore > 0)
        {
            popupManager.ShowPopup("�̴ϰ��� ���� ����: " + GameManager.finalScore + "��");
            GameManager.finalScore = 0; // �˾� ǥ�� �� ���� �ʱ�ȭ
        }
        else if (popupManager != null)
        {
            // ������ ���ų� 0�̶�� �˾��� ó������ ��Ȱ��ȭ (ShowPopup�� ȣ����� �ʾ����Ƿ�)
            popupManager.popupPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("MainSceneManager: PopupManager�� ������� �ʾҽ��ϴ�. ���� �˾��� ǥ���� �� �����ϴ�.");
        }
    }
}
