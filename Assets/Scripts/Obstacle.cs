using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Player player;
    [SerializeField] private ParticleSystem explosion;
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Obstacle"){
            
            //Play Explosion Particles and Sound
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            
            Destroy(col.gameObject);
            player.score--;

        }
    }
}
