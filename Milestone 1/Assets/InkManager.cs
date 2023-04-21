using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

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
        DisplayNextLine();
    }

    public void DisplayNextLine()
    {
        if (!_story.canContinue) return;

        string text = _story.Continue(); // gets next line
        text = text?.Trim(); // removes white space from text
        _textField.text = text; // displays new text
    }

}
