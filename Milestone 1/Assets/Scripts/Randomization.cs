using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomization : MonoBehaviour
{
   public int yPos;
   public int xPos;
   public GameObject theButton;
   
   Text pressesLeft;
    public int buttonPresses;

    // Update is called once per frame 
    private void Start()
    {
        buttonPresses = 15;
        pressesLeft = GetComponent<Text>();
        pressesLeft.text = "Presses Left: " + buttonPresses;
    }
    void Update()
    {
      if(Input.GetButtonDown("Submit"))
        {
           yPos = Random.Range( -425, 425);
           xPos = Random.Range( -874, 874);
           theButton.transform.localPosition = new Vector3(xPos,yPos, 0);

            buttonPresses = buttonPresses - 1;
            pressesLeft.text = "Presses Left: " + buttonPresses;
        } 
    }
}
