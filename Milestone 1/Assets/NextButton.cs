using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{

    public InkManager _inkManager;

    // Start is called before the first frame update
    void Start()
    {
        _inkManager = FindObjectOfType<InkManager>();

        if (_inkManager == null)
        {
            Debug.LogError("Ink Manager was not found!");
        }
    }

    public void OnClick()
    {
        _inkManager.DisplayNextLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
