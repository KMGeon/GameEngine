using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

   
    [SerializeField]float speed = 1f;
    List<Waypoint> path = new List<Waypoint>();
    Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }



    void OnEnable()
    {
        FindPath();
        ReturnToStart();
        StartCoroutine( FollowPath());
    }
    void ReturnToStart()
    {
        transform.position = path[0].transform.position;
    }

    void FindPath()
    {
        path.Clear();
        GameObject parent = GameObject.FindWithTag("Path");
        foreach(Transform child in parent.transform)
        {
            path.Add(child.GetComponent<Waypoint>());
        }
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
        gameObject.SetActive(false);
        enemy.StealGold();
            
    }
}
