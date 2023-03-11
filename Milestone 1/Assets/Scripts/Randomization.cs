using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomization : MonoBehaviour
{
   public int yPos;
   public int xPos;
   public GameObject theButton;

    public GameObject thePresses;
    Text pressesLeft;
    public int buttonPresses;
    
    

    // Update is called once per frame 
    public void start() 
    {
        buttonPresses = 20;
        pressesLeft = thePresses.GetComponent<Text>();
        pressesLeft.text = "Presses Left: " + buttonPresses;
        if(onClick.GetComponent.<theButton>(). && buttonPresses > 0)
        {
           yPos = Random.Range( -425, 425);
           xPos = Random.Range( -874, 874);
           theButton.transform.localPosition = new Vector3(xPos,yPos, 0);

            buttonPresses = buttonPresses - 1;
            pressesLeft.text = "Presses Left: " + buttonPresses;
        } 
    }
 
}
