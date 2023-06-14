using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioFiles[] sounds;

    void Awake()
    {
        foreach (AudioFiles sound in sounds)
        {

            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.playOnAwake = false;

        }
    }
  
  //To play one audio
    public void Play(string name)
    {
            AudioFiles Sound = Array.Find(sounds, sound => sound.name == name);
             Sound.source.Play();
    }

    //To play multiple audios
    public void PlayOneShot(string name)
    {

            AudioFiles Sound = Array.Find(sounds, sound => sound.name == name);
            Sound.source.PlayOneShot(Sound.clip);
    }

    //To stop audios 
    public void Stop(string name)
    {
            AudioFiles Sound = Array.Find(sounds, sound => sound.name == name);
            Sound.source.Stop();
    }
}
