using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 10f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            if (distanceToTarget > navMeshAgent.stoppingDistance)
            {
                ChaseTarget();
            }
            else
            {
                AttackTarget();
            }

        }else if (distanceToTarget<=chaseRange)
        {
            isProvoked = true;
        }

    }
    void AttackTarget()
    {
        print($"{name}is attacking{target.name}");
    }

    void ChaseTarget()
    {
        navMeshAgent.SetDestination(target.position);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
