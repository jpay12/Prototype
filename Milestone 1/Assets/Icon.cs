using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
   public GameObject PossumIcons;

   public GameObject Owl; 

   public GameObject OwlIcons;

   public GameObject Fish;  

   public GameObject FishIcons; 
 
    // Use this for initialization
    void Start () {
        StartCoroutine(HideAndShow(2.0f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator ShowAndHide(float delay)
    {
        PossumIcons.SetActive(false);
        yield return new WaitForSeconds(2f);
        PossumIcons.SetActive(true);
    }
}
