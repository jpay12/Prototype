using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public int xPos;
   public int yPos; 
   public GameObject theButton; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            xPos = Random.Range(30,80);
            yPos = Random.Range(100,180);
            theButton.transform.position = new Vector3(xPos, -9.8f, yPos); 
        } 
    }
}
