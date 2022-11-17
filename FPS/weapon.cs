using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    [SerializeField] Camera FPSCamera;
    [SerializeField] ParticleSystem gunVFX;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gunVFX.Play();
            RaycastHit raycastHit;
            if (Physics.Raycast(FPSCamera.transform.position,FPSCamera.transform.forward,out raycastHit, range))
            {
                GameObject impact = Instantiate(explosion, raycastHit.point, Quaternion.LookRotation(raycastHit.normal));
                Destroy(impact, 0.1f);
                EnemyHealth target = raycastHit.transform.GetComponent<EnemyHealth>();
                if (target == null)
                {
                    return;
                }
                target.TakeDamage(damage);
            }
        }   
    }
}
