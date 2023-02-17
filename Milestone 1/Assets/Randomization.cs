using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
   public int xPos;
   public int yPos; 
   public GameObject theButton; 
  
    // Update is called once per frame 
    void Update()
    {
      if(Input.GetButtonDown("Submit"))
        {
           xPos = Random.Range(0,300);
           yPos = Random.Range(150,200);
           theButton.transform.position = new Vector3(xPos, -9.8f, yPos); 
        } 
    }
}
