using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //serializeField 프로퍼티를 붙이면 unity에서 변경이 가능하다.
    // [SerializeField]float xValue = 0;
    //[SerializeField]float zValue =0;
    [SerializeField] float moveSpeed = 10f;
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
