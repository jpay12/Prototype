using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour
{
    private float timeStart = 60;
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
            timeStart = 0; 
            SceneManager.LoadScene("Failed"); 
        }
    
    }

}
