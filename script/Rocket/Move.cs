using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float pushForce = 1000f;
    [SerializeField] float rotationForce = 200f;
    [SerializeField] AudioClip audioClipBoost;
    Rigidbody rigidbody;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * pushForce);
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioClipBoost);
            }
        }
        else
        {
            audioSource.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-Vector3.forward);
        }
    }

    void ApplyRotation(Vector3 vector)
    {
        rigidbody.freezeRotation = true;
        transform.Rotate(vector * Time.deltaTime * rotationForce);
        rigidbody.freezeRotation = false;
    }
}
