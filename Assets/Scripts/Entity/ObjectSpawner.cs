using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;        // 积己且 橇府普
    public Transform spawnPoint;     // 积己 困摹

    public void Spawn()
    {
        Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
