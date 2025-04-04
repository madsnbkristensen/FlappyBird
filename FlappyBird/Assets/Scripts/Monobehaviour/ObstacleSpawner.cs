using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnRate = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnRate);
    }

    private void SpawnObstacle()
    {
        GameObject newPipe = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        Vector3 tempPos = newPipe.transform.position;
        tempPos.y = Random.Range(-1.5f, 1.5f);
        newPipe.transform.position = tempPos;
        
    }
}
