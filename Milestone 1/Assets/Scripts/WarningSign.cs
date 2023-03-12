using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSign : MonoBehaviour
{
    public GameObject Sign; 
    
    // Use this for initialization
    void Start () {
        StartCoroutine(HideAndShow(5f) );
    }
 
    // Update is called once per frame
    void Update () {
   
    }

    IEnumerator HideAndShow (float delay)
    {
        Sign.SetActive(false);
        yield return new WaitForSeconds(5f);
        Sign.SetActive(true);
    } 
}
