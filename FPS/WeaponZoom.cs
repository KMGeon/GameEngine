using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    float zoomedOutFOV = 60f;
    float zoomedInFOV = 20f;
    bool zoomedInToggle = false;
    RigidbodyFirstPersonController fpsController;
    float zoomedOutSensitivity = 2f;
    float zoomedInSensitivity = .5f;


    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            zoomedInToggle = !zoomedInToggle;
            fpsCamera.fieldOfView = zoomedInToggle ? zoomedInFOV : zoomedOutFOV;
            fpsController.mouseLook.XSensitivity = zoomedInToggle ? zoomedInSensitivity : zoomedOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedInToggle ? zoomedInSensitivity : zoomedOutSensitivity;
        }
    }
}
