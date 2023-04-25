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

        //Was me trying to set it up so characters would appear in a certain spot whenever they talk

        _story.BindExternalFunction("ShowCharacter", (string name, string position, string mood)
            => Debug.Log($"Show character called. {name}, {position}, {mood}"));
        
        _story.BindExternalFunction("HideCharacter", (string name)
            => Debug.Log($"Hide character called. {name}")); 

        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        //if (!_story.canContinue) return;

        //Cinematics
        if (!_story.canContinue && SceneManager.GetActiveScene().name == "Cine1")
        {
            SceneManager.LoadScene("Concert Overview");
        } 
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "Cine2")
        {
            SceneManager.LoadScene("Ending Concert Overview");
        }
        //Hub convos
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "H1_Haley_Convo")
        {
            SceneManager.LoadScene("Hub1");
        }
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "H1_Ace_Convo")
        {
            SceneManager.LoadScene("Hub1");
        }
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "H1_Kurt_Convo")
        {
            SceneManager.LoadScene("Hub1");
        }
        else if (!_story.canContinue && SceneManager.GetActiveScene().name == "H1_MJ_Convo")
        {
            SceneManager.LoadScene("Hub1");
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
