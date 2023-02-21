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
           yPos = Random.Range( -425, 425);
           xPos = Random.Range( -874, 874);
           theButton.transform.localPosition = new Vector3(xPos,yPos, 0);
            print(theButton.transform.localPosition);
        } 
    }
}
