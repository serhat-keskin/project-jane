using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip Laserfx;
    public AudioClip Absorptionfx;
    public AudioClip Deabsorptionfx;
    public AudioClip Doorfx;
    public AudioClip Robotfx;
    public AudioClip platformSound;
    public AudioClip RobotDeathFx;

    public static SoundManager instance;
    private void Awake()
    {
        instance = this;
    }

    public void PlayFX(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }
}
