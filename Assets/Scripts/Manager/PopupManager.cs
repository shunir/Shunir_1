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
            Debug.LogWarning("PopupManager: popupPanel이 연결되지 않았습니다.");
        }
    }

    public void ShowPopup(string message)
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);
            if (scoreText != null)
            {
                scoreText.text = message; // 팝업 텍스트 설정
            }
            else
            {
                Debug.LogWarning("PopupManager: scoreText UI가 연결되지 않았습니다. 팝업 텍스트를 설정할 수 없습니다.");
            }
        }
    }

    public void ClosePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(false); // 팝업 비활성화
        }
        MINIGameData.GameData.LastScore = 0; // 다시 초기화
    }
}

