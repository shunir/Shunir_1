using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    public PopupManager popupManager; // PopupManager 연결

    void Start()
    {
        if (popupManager != null && GameManager.finalScore > 0)
        {
            popupManager.ShowPopup("미니게임 최종 점수: " + GameManager.finalScore + "점");
            GameManager.finalScore = 0; // 팝업 표시 후 점수 초기화
        }
        else if (popupManager != null)
        {
            // 점수가 없거나 0이라면 팝업을 처음부터 비활성화 (ShowPopup이 호출되지 않았으므로)
            popupManager.popupPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("MainSceneManager: PopupManager가 연결되지 않았습니다. 점수 팝업을 표시할 수 없습니다.");
        }
    }
}
