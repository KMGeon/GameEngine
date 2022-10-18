using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem enemyExplosion;
    [SerializeField] ParticleSystem enemyHit;
    ScoreBoard scoreBoard;
    [SerializeField]int scorePerHit = 15;
    [SerializeField]int hitPoint = 10;

    private void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
     }

    private void OnParticleCollision(GameObject other)
    {
        hitPoint--;
        scoreBoard.IncreaseScore(scorePerHit);
        if (hitPoint < 1)
        {
            ParticleSystem explosion = Instantiate(enemyExplosion, transform.position, Quaternion.identity);
            explosion.Play();
            Destroy(gameObject);
        }
        else
        {
            ParticleSystem hit = Instantiate(enemyHit,  new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
            hit.Play();
        }

     
      
     
    }

}
