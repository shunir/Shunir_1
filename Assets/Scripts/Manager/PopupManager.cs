using UnityEngine;
using UnityEngine.UI;
using static MINIGameData;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPanel;
    public Text scoreText;

    void Start()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("PopupManager: popupPanel�� ������� �ʾҽ��ϴ�.");
        }
    }

    public void ShowPopup(string message)
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);
            if (scoreText != null)
            {
                scoreText.text = message; // �˾� �ؽ�Ʈ ����
            }
            else
            {
                Debug.LogWarning("PopupManager: scoreText UI�� ������� �ʾҽ��ϴ�. �˾� �ؽ�Ʈ�� ������ �� �����ϴ�.");
            }
        }
    }

    public void ClosePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false); // �˾� ��Ȱ��ȭ
        }
        MINIGameData.GameData.LastScore = 0; // �ٽ� �ʱ�ȭ
    }
}

