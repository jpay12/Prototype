using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour
{
    public void Scene1() {  
        SceneManager.LoadScene("Scene1");  
    } 

    public void Scene2() {  
        SceneManager.LoadScene("Scene2");  
    }   
}
