using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] ParticleSystem crashVFV;

    private void OnTriggerEnter(Collider other)
    {
        crashVFV.Play();
        StartCrash();

    }

    private void StartCrash()
    {
        GetComponent<PlayerControllers>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        Invoke("RoadLevel", 1f);
    }

    void RoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
