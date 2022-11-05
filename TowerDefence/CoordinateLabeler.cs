using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordidates = new Vector2Int();//��ǥ


    void Start()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
        UpdateObjectsName();

    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
            DisplayCoordinates();
            UpdateObjectsName();
    }

    void DisplayCoordinates()
    {
        coordidates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);//�θ��� ��ǥ
        coordidates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);//�θ��� ��ǥ
        label.text = coordidates.x + " , " + coordidates.y;
    }

    void UpdateObjectsName()
    {
        transform.parent.name = coordidates.ToString();
    }

}
