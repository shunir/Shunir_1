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
            Debug.Log("�̴ϰ��� ������Ʈ ��ó�� �ֽ��ϴ�. FŰ�� ���� ��ȣ�ۿ��ϼ���.");
        }
        
        else if (other.CompareTag("WallTrigger")) 
        {
            Debug.Log("WallTrigger�� ��ҽ��ϴ�.");
            
        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.CompareTag("MiniGame")) 
        {
            canInteract = false;
            Debug.Log("�̴ϰ��� ������Ʈ���� ������ϴ�.");
        }
    }

  
    
 
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("���� �ε������ϴ�. ������ ��ӵ˴ϴ�.");
        }
    }



    void Update()
    {
        
        if (canInteract && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("FŰ �Է� ����! �÷��ǹ��� ������ �̵��մϴ�.");
            SceneManager.LoadScene("FlappyPlane_Project"); 
        }
    }
}