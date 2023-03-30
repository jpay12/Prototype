using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text textBox;

    void Start(){
        textBox.text = timeStart.ToString(); 
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = "Time Remaining:" + Mathf.Round(timeStart).ToString("0"); 
        if(timeStart <= 0)
        {
            GameOver(); 
            timeStart = 0; 
        }
    
    }

        public void GameOver()
        {
            Application.Quit(); 
        }
}
