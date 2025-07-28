using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    public PopupManager popupManager; // PopupManager 연결

    void Start()
    {
        if (popupManager != null && MINIGameData.GameData.LastScore > 0)
        {
            popupManager.ShowPopup("미니게임 점수: " + MINIGameData.GameData.LastScore);
            MINIGameData.GameData.LastScore = 0;
        }
    }
}
