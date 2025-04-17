using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }

    public AudioSource grassWalkSound;
    public AudioSource jumpSound;
    public AudioSource selectButtonSound;
    public AudioSource questConfirmSound;
    public AudioSource playerHitSound;
    public AudioSource enemyHitSound;
    public AudioSource playerTakeDamageSound;
    public AudioSource playerDeathSound;
    public AudioSource enemyTakeDamageSound;
    public AudioSource enemyDeathSound;
    public AudioSource respawnSound;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    
    public void PlaySound(AudioSource soundToPlay)
    {
        if (soundToPlay.isPlaying)
        {
            soundToPlay.Play();
        }
    }

}
