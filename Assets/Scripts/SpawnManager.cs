using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3[] spawnPoint = new Vector3[5];
    public GameObject enemy;

    private float enemySpawnDelayTime = 5f;

    void Start()
    {
        SetSpawnPoint();

        InvokeRepeating("EnemySpawn", 0, enemySpawnDelayTime);
    }

    private void SetSpawnPoint()
    {
        int i = 0;
        int start = -2;
        while (i < 5)
        {
            spawnPoint[i] = new Vector3(start, this.transform.position.y, 0);
            start ++;
            i++;
        }
    }

    // Update is called once per frame
    void EnemySpawn()
    {
        int rnd = Random.Range(0, spawnPoint.Length);
        for(int i = 0; i < spawnPoint.Length; i++)
        {
            if (i == rnd) continue;

            Instantiate(enemy, spawnPoint[i], Quaternion.identity, this.transform);
        }
    }
}
