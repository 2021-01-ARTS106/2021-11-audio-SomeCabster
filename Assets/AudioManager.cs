using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour{
    public static AudioManager manager;

    private voidd Awake()
    {
        manager = this;
    }

    public AudioSource mainMusic;
    public AudioSource auxMusic;
    public AudioSource ambSound;


}
