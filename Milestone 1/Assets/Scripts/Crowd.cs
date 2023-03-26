using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
     public GameObject Possum;
     public GameObject Owl;
     public GameObject Fish; 
     public GameObject PossumEmotion; 
    
    // Use this for initialization
    void Start () {
        StartCoroutine(HideAndShow(10f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator HideAndShow (float delay)
    {
        Owl.SetActive(false);
        yield return new WaitForSeconds(1f);
        Owl.SetActive(true); 

        Fish.SetActive(false);
        yield return new WaitForSeconds(5f);
        Fish.SetActive(true); 
          
        PossumEmotion.SetActive(true);
        yield return new WaitForSeconds(2f);
        PossumEmotion.SetActive(false); 

        Possum.SetActive(true);
        yield return new WaitForSeconds(3f);
        Possum.SetActive(false); 
      

    } 

}
