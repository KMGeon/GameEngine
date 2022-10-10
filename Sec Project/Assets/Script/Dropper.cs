
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timeToWait = 4f;
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //처음에 화면 안보이게
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}