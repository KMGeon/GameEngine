using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }
    [SerializeField] Tower tower;
    [SerializeField] GameObject towerPrefab;

    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced =tower.Createtower(transform.position);
            Instantiate(towerPrefab, transform.position, Quaternion.identity);
            isPlaceable = !isPlaced;
        }
    } 
}
