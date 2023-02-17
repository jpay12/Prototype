using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomization : MonoBehaviour
{
   public int yPos;
   public int zPos; 
   public int xPos;
   public GameObject theButton; 
  
    // Update is called once per frame 
    void Update()
    {
      if(Input.GetButtonDown("Submit"))
        {
           yPos = Random.Range(5,-5);
           zPos = Random.Range(0,-10);
           xPos = Random.Range(3,100);
           theButton.transform.position = new Vector3(0f, yPos, zPos); 
        } 
    }
}
