using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    float levelLoadDelay = 1.5f;
    [SerializeField] AudioClip audioClipSuccess;
    [SerializeField] AudioClip audioClipCrash;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case "friendly":
                Debug.Log("freindly");
                break;

            case "Finish":
                audioSource.PlayOneShot(audioClipSuccess);
                GetComponent<Move>().enabled = false;
                Invoke("LoadNextLevel", levelLoadDelay);
               
                break;

            default:
                audioSource.PlayOneShot(audioClipCrash);
                GetComponent<Move>().enabled = false;
                Invoke("ReloadLevel", levelLoadDelay);
                break;
        }
    }
    void LoadNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
