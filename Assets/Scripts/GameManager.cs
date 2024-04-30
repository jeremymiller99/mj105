using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float gameTime;
    [SerializeField] private float countdown = 3;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text countdownText;
    [SerializeField] private GameObject countdownMenu;
    public bool playing;
    void Start()
    {
        countdownMenu.SetActive(true);
        playing = false;
        gameTime = 30;
        countdown = 3;
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = countdown.ToString("F1");
        
        if(!playing){
            StartGame();
        }else{
            if(gameTime>0){
                gameTime -= Time.deltaTime;
                timeText.text = gameTime.ToString("F1");
            } else {
                Debug.Log("Game over");
            }
        }  
    }
    
    void StartGame(){
        if (countdown>0){
            countdown -= Time.deltaTime;
        } else {
            countdownMenu.SetActive(false);
            playing = true;
        }
    }
}
