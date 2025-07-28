using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;       
    public Transform spawnPoint;    

    void Start()
    {
       
        Spawn();
    }

    
    public void Spawn()
    {
       
        if (prefab != null)
        {
            
            Vector3 finalSpawnPosition = (spawnPoint != null) ? spawnPoint.position : transform.position;

          
            GameObject spawnedObject = Instantiate(prefab, finalSpawnPosition, Quaternion.identity);
            Debug.Log($"�̴ϰ��� ��ȣ�ۿ� ������Ʈ ������: {spawnedObject.name} at {finalSpawnPosition}");

            
        }
        else
        {
            Debug.LogError("ObjectSpawner: ������ ������(prefab)�� ������� �ʾҽ��ϴ�!");
        }
    }
}