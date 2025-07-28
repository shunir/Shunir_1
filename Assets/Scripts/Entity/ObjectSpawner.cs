using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;        // ������ ������
    public Transform spawnPoint;     // ���� ��ġ

    public void Spawn()
    {
        Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
