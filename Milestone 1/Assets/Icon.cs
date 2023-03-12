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
        StartCoroutine(HideAndShow(2f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator HideAndShow (float delay)
    {
        Possum.SetActive(true);
        yield return new WaitForSeconds(2f);
        Possum.SetActive(false);

        Owl.SetActive(true);
        yield return new WaitForSeconds(3f);
        Owl.SetActive(true);

       
       Fish.SetActive(true);
        yield return new WaitForSeconds(4f);
       Fish.SetActive(true);

    }
   
}





