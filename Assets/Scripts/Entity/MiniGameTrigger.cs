using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameTrigger : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SceneManager.LoadScene("MiniGameScene");
    }
}

