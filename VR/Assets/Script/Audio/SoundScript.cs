using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundScript 
{
  public  AudioClip clip;
  public  string name;
    [Range(0,1)]
  public  float volume;

}
