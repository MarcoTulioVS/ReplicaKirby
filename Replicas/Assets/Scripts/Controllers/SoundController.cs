using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioSource audioSourceContinuous;

    public List<AudioClip>audios = new List<AudioClip>(); 
    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }

    public void PlaySoundContinuous(AudioClip clip)
    {
        audioSourceContinuous.clip = clip;
        audioSourceContinuous.Play();
    }

    public void StopSoundContinuous()
    {
        audioSourceContinuous.clip = null;
        audioSourceContinuous.Stop();
    }
}
