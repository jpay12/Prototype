using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
   public int yPos;
   public int xPos;
   public GameObject theButton; 
  
    // Update is called once per frame 
    void Update()
    {
      if(Input.GetButtonDown("Submit"))
        {
           yPos = Random.Range( 120,255);
           xPos = Random.Range(100,200);
           theButton.transform.position = new Vector3(xPos,yPos,0f); 
        } 
    }
}
