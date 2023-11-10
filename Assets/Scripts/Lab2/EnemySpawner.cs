using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;// thời gian mỗi lần xuất hien
    public float spawnRadius = 5f;// bán kính xuất hiện

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);// lặp đi lặp lại theo thời gian spawnInterval được xác định 
    }

    private void SpawnEnemy()
    {
        //tạo ra một vị trí ngẫu nhiên xung quanh vị trí của EnemySpawner,
        //sau đó sử dụng Instantiate() để tạo ra một đối tượng kẻ thù (enemyPrefab) tại vị trí đó.
        
        Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
