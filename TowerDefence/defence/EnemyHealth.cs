using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 1;
    int difficulty = 1;
    int currentHitPoint = 0;
    Enemy enemy;


    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void OnEnable()
    {
        currentHitPoint = maxHitPoint;
    }

    // Update is called once per frame
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoint--;
        if (currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGolad();
            maxHitPoint += difficulty;
        }

    }
}
