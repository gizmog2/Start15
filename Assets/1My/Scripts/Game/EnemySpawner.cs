using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] float SpawnTime = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTimer", 0, SpawnTime);
        
    }

    void SpawnTimer()
    {
        GameObject enemyu = Instantiate(EnemyPrefab, transform.position, transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
