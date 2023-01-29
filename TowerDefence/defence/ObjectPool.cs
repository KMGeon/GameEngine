using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] int poolSize = 10;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 1f;
    GameObject[] pool;
    void Start()
    {
        PopulatePool();
        StartCoroutine(SpawnEnemy());
    }


    void PopulatePool()
    {
        pool = new GameObject[poolSize];
        for(int i=0; i < poolSize; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false);
        }

    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTimer);
        }
    }
    void EnableObjectInPool()
    {
        for(int i=0; i < poolSize; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                pool[i].SetActive(true);
                return;
            }
        }

    }

}
