using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
   public GameObject Possum;

   public GameObject Owl; 

   public GameObject Fish;  

  
 
    // Use this for initialization
    void Start () {
        StartCoroutine(HideAndShow(1f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator HideAndShow(float delay)
    {
        Possum.SetActive(false);
        yield return new WaitForSeconds(2f);
        Possum.SetActive(true);

        Owl.SetActive(true);
        yield return new WaitForSeconds(2f);
        Owl.SetActive(false);

       
       Fish.SetActive(false);
        yield return new WaitForSeconds(2f);
       Fish.SetActive(false);

    }
   
}





