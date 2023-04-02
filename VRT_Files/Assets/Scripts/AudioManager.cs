using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    Object[] myMusic; // declare this as Object array
    
    //Loads audio tracks
    void Awake()
    {
        myMusic = Resources.LoadAll("Audio", typeof(AudioClip));
        GetComponent<AudioSource>().clip = myMusic[0] as AudioClip;
    }

    //Plays on awake
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
            playRandomMusic();
    }

    //Randomizes the music played
    void playRandomMusic()
    {
        GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        GetComponent<AudioSource>().Play();
    }
}
