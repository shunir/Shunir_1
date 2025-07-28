using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;         
    public Vector2 spawnAreaMin;     
    public Vector2 spawnAreaMax;

    void Start()
    {

        SpawnRandomInArea();
    }


    public void SpawnRandomInArea()
    {
        if (prefab == null)
        {
            return;
        }

        float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float randomY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
        Vector3 finalSpawnPosition = new Vector3(randomX, randomY, 0f);

        GameObject spawnedObject = Instantiate(prefab, finalSpawnPosition, Quaternion.identity);
        Debug.Log($"�̴ϰ��� ������Ʈ ����: {spawnedObject.name} at {finalSpawnPosition}");
    }
}