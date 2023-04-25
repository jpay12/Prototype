using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using UnityEngine.SceneManagement;

public class InkManager : MonoBehaviour
{

    public TextAsset _inkJsonAsset;
    public Story _story;
    public Text _textField;


    // Start is called before the first frame update
    void Start()
    {
        

        StartStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void StartStory()
    {
        _story = new Story(_inkJsonAsset.text);

        _story.BindExternalFunction("ShowCharacter", (string name, string position, string mood)
            => Debug.Log($"Show character called. {name}, {position}, {mood}"));

        _story.BindExternalFunction("HideCharacter", (string name)
            => Debug.Log($"Hide character called. {name}"));

        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        //if (!_story.canContinue) return;


        if (!_story.canContinue && SceneManager.GetActiveScene().name == "Cine1")
        {
            SceneManager.LoadScene("Concert Overview");
        } 
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "Cine2")
        {
            SceneManager.LoadScene("Ending Concert Overview");
        }

        string text = _story.Continue(); // gets next line
        text = text?.Trim(); // removes white space from text
        _textField.text = text; // displays new text
    }

    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    } 

}
