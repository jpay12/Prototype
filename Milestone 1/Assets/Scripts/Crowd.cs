using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
     
     
     public GameObject Possum;
     public GameObject PossumEmotion;
     public GameObject PossumEmotion1;
     public GameObject PossumEmotion2;

     public GameObject Owl;
     public GameObject OwlEmotion;
     public GameObject OwlEmotion1;
     public GameObject OwlEmotion2;

     public GameObject Fish;
     public GameObject FishEmotion;
     public GameObject FishEmotion1;
     public GameObject FishEmotion2;


    // Use this for initialization
    void Start () 
    {
        StartCoroutine(HideAndShow(10f) );
    }

    IEnumerator HideAndShow (float delay)
    {
        Owl.SetActive(false);
        yield return new WaitForSeconds(1f);
        Owl.SetActive(true); 

        Fish.SetActive(false);
        yield return new WaitForSeconds(4f);
        Fish.SetActive(true); 
          
        PossumEmotion.SetActive(true);
        yield return new WaitForSeconds(2f);
        PossumEmotion.SetActive(false); 
     
    } 

}
