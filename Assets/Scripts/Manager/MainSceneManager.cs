using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{
    public PopupManager popupManager; // PopupManager ����

    void Start()
    {
        if (popupManager != null && MINIGameData.GameData.LastScore > 0)
        {
            popupManager.ShowPopup("�̴ϰ��� ����: " + MINIGameData.GameData.LastScore);
            MINIGameData.GameData.LastScore = 0;
        }
    }
}
