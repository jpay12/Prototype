using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
     public GameObject Possum;
     public GameObject Owl;
     public GameObject Fish;  
    
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
        yield return new WaitForSeconds(5f);
        Owl.SetActive(true); 

        Fish.SetActive(false);
        yield return new WaitForSeconds(7f);
        Fish.SetActive(true); 

        Possum.SetActive(true);
        yield return new WaitForSeconds(10f);
        Possum.SetActive(false); 
    } 

}
