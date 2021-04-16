using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

   //Public Variables
    public static AudioManager instance;

    //Private variables
    private AudioSource audioSource;

    #region
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }else if(instance!=this)
        {
            Destroy(gameObject);
        }
    }

    #endregion


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayAmbientMusic();
    }

    //Private Variables
    public SoundScript[] sounds;


    public void PlayAmbientMusic()
    {
        audioSource.PlayOneShot(sounds[0].clip);
    }


}
