using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour
{

    public FMOD.Studio.EventInstance musicTrack;


    // Start is called before the first frame update
    void Start()
    {
        musicTrack = FMODUnity.RuntimeManager.CreateInstance("event:/Music/Song for Presentation_mixdown(Real)");
        musicTrack.start();
    }

    // Update is called once per frame
    void Update()
    {
        
        DontDestroyOnLoad(gameObject);
    }
}
