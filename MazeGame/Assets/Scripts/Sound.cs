using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {

    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;

    public string name;
    [Range(0, 1)]
    public float volume;

     
}
