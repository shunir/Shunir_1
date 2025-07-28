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
            Debug.Log($"미니게임 상호작용 오브젝트 생성됨: {spawnedObject.name} at {finalSpawnPosition}");

            
        }
        else
        {
            Debug.LogError("ObjectSpawner: 생성할 프리팹(prefab)이 연결되지 않았습니다!");
        }
    }
}