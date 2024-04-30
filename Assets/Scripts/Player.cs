using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float speed = 10;
    public int score;
    [SerializeField] private ParticleSystem explosion;
    void Start(){
        
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }
    void Update()
    {
        Movement();
        scoreText.text = score.ToString();
    }
    void Movement(){
       float dir = Input.GetAxisRaw("Horizontal");
       rb.velocity = new Vector2(speed*dir*Time.fixedDeltaTime, rb.velocity.y);
    }
    
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Obstacle"){
            
            //Play Explosion Particles
            Instantiate(explosion, col.transform.position, Quaternion.identity);
            
            Destroy(col.gameObject);
            score++;
        }
    }
}
