using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    private void OnEnable()
    {
        
        SoundController.instance.PlaySoundContinuous(SoundController.instance.audios[2]);
    }

    private void OnDisable()
    {
        SoundController.instance.StopSoundContinuous();
    }
}
