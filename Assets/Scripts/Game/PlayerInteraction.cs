using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    private bool canInteract = false;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("MiniGame")) 
        {
            canInteract = true;
            Debug.Log("미니게임 오브젝트 근처에 있습니다. F키를 눌러 상호작용하세요.");
        }
        
        else if (other.CompareTag("WallTrigger")) 
        {
            Debug.Log("WallTrigger에 닿았습니다.");
            
        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.CompareTag("MiniGame")) 
        {
            canInteract = false;
            Debug.Log("미니게임 오브젝트에서 벗어났습니다.");
        }
    }

  
    
 
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("벽에 부딪혔습니다. 게임은 계속됩니다.");
        }
    }



    void Update()
    {
        
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F키 입력 감지! 플래피버드 씬으로 이동합니다.");
            SceneManager.LoadScene("FlappyPlane_Project"); 
        }
    }
}