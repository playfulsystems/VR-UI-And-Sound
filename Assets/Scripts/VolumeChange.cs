using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    public AudioSource musicSource;

    public void SliderChange(float val)
    {
        musicSource.volume = val;
    }
}
