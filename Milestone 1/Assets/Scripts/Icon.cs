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
        StartCoroutine(HideAndShow(5f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator HideAndShow (float delay)
    {
        Possum.SetActive(true);
        yield return new WaitForSeconds(2f);
        Possum.SetActive(false);

        Owl.SetActive(false);
        yield return new WaitForSeconds(5f);
        Owl.SetActive(true);

       
       Fish.SetActive(false);
        yield return new WaitForSeconds(6f);
       Fish.SetActive(true);

    }
   
}





