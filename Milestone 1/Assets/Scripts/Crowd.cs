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

        PossumEmotion1.SetActive(false);
        PossumEmotion.SetActive(true);
        yield return new WaitForSeconds(4f);
        PossumEmotion1.SetActive(true);
        PossumEmotion.SetActive(false);

        OwlEmotion.SetActive(true);
        OwlEmotion1.SetActive(false);
        yield return new WaitForSeconds(3f);
        OwlEmotion1.SetActive(true);
        OwlEmotion.SetActive(false);

        FishEmotion.SetActive(true);
        FishEmotion1.SetActive(false);
        yield return new WaitForSeconds(3f);
        FishEmotion1.SetActive(true);
        FishEmotion.SetActive(false);

        PossumEmotion1.SetActive(true);
        PossumEmotion2.SetActive(false);
        yield return new WaitForSeconds(4f);
        PossumEmotion2.SetActive(true);
        PossumEmotion1.SetActive(false);

        OwlEmotion1.SetActive(true);
        OwlEmotion2.SetActive(false);
        yield return new WaitForSeconds(3f);
        OwlEmotion2.SetActive(true);
        OwlEmotion1.SetActive(false);

        FishEmotion1.SetActive(true);
        FishEmotion2.SetActive(false);
        yield return new WaitForSeconds(3f);
        FishEmotion2.SetActive(true);
        FishEmotion1.SetActive(false);
    } 

}
