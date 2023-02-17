using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
   public int xPos;
   public int yPos; 
   public GameObject theButton; 
  
    // Update is called once per frame 
    void Update()
    {
      if(Input.GetMouseButton("click"))
        {
           int xPos = Random.Range(1,300);
           int yPos = Random.Range(100,200);
           theButton.transform.position = new Vector3(xPos, -9.8f, yPos); 
        } 
    }
}
