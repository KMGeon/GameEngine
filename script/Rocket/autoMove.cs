using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMove : MonoBehaviour
{
    Vector3 startPosition;
    Vector3 movementVector = new Vector3(10f, 0, 0);
    const float period = 4f;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycle = Time.time / period;
        float rawSinWave = Mathf.Sin(cycle * Mathf.PI * 2);
        Vector3 offset = (rawSinWave + 1f) / 2f * movementVector;
        transform.position = startPosition + offset;
    }
}
