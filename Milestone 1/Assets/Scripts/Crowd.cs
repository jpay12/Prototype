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

        PossumEmotion1.SetActive(false);
        yield return new WaitForSeconds(5f);
        PossumEmotion1.SetActive(true);

        PossumEmotion2.SetActive(false);
        yield return new WaitForSeconds(7f);
        PossumEmotion2.SetActive(true);

        OwlEmotion.SetActive(false);
        yield return new WaitForSeconds(1f);
        OwlEmotion.SetActive(true);

        OwlEmotion1.SetActive(false);
        yield return new WaitForSeconds(7f);
        OwlEmotion1.SetActive(true);

        OwlEmotion2.SetActive(false);
        yield return new WaitForSeconds(9f);
        OwlEmotion2.SetActive(true);

        FishEmotion.SetActive(false);
        yield return new WaitForSeconds(4f);
        FishEmotion.SetActive(true);

        FishEmotion1.SetActive(false);
        yield return new WaitForSeconds(9f);
        FishEmotion1.SetActive(true);

        FishEmotion2.SetActive(false);
        yield return new WaitForSeconds(10f);
        FishEmotion2.SetActive(true);
    } 

}
