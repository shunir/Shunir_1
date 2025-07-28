using UnityEngine;
using UnityEngine.UI;
using static MINIGameData;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPanel;
    public Text scoreText;

    void Start()
    {
        popupPanel.SetActive(false); // 시작 시 비활성화
    }

    public void ShowPopup(string message)
    {
        popupPanel.SetActive(true);
        scoreText.text = message;
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        MINIGameData.GameData.LastScore = 0; // 다시 초기화
    }
}

