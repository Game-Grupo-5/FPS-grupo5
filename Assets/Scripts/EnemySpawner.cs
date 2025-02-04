using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    [Header("Timer Enemy")]
    private float spawnTimer = 0f;
    public float nextSpawn = 5f;

    [Header("Enemy")]
    public GameObject[] Enemy;

    private Vector3 spawnPos;

    void Start()
    {
        
    }

    void Update()
    {
        //x=73 z=-73
        //x=-74 z= 72


    }

    private void FixedUpdate()
    {
        spawnTimer += Time.deltaTime;

        //print(spawnTimer);


        if (spawnTimer >= nextSpawn)
        {

            spawnTimer = 0;

            float spanwX = Random.Range(-58, 59);
            float spanwZ = Random.Range(18,58);
            spawnPos = new Vector3(spanwX, 2, spanwZ);


            Instantiate(Enemy[Random.Range(0,Enemy.Length)], spawnPos, Quaternion.identity);
        }
    }
}
