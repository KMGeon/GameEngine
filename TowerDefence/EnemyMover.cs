using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField]float speed = 1f;

    void Start()
    {
        StartCoroutine( FollowPath());
    }

      IEnumerator FollowPath()
    {

        foreach (Waypoint waypoint in path)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPossotion = waypoint.transform.position;
            float travelPercent = 0f;
            transform.LookAt(endPossotion);
            while (travelPercent < 1f)
            {
                travelPercent += Time.deltaTime*speed;
                transform.position = Vector3.Lerp(startPosition, endPossotion, travelPercent);
                yield return new WaitForEndOfFrame(); 
            }

         //waypoint ->타일의 위치
        }
            
    }
}
