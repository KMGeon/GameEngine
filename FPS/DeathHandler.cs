using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas GameoverCanvas;
    void Start()
    {
        GameoverCanvas.enabled = false;

    }

    public void HandleDeath()
    {
        GameoverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
