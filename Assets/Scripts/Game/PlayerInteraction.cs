using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    private bool canInteract = false;

    // Mini Game 오브젝트와 충돌 시
    private void OnTriggerEnter2D(Collider2D other) // 3D인 경우 OnTriggerEnter로 변경
    {
        if (other.CompareTag("minigame"))
        {
            canInteract = true;
            Debug.Log("미니게임 오브젝트 근처에 있습니다. F키를 눌러 상호작용하세요.");
        }
    }

    // Mini Game 오브젝트에서 벗어날 시
    private void OnTriggerExit2D(Collider2D other) // 3D인 경우 OnTriggerExit로 변경
    {
        if (other.CompareTag("minigam"))
        {
            canInteract = false;
            Debug.Log("미니게임 오브젝트에서 벗어났습니다.");
        }
    }

    void Update()
    {
        // F키를 누르고 상호작용 가능한 상태일 때
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F키 입력 감지! 플로피버드 씬으로 이동합니다.");
            SceneManager.LoadScene("FlappyPlane_Project"); // 플로피버드 씬 이름으로 변경
        }
    }
}