using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounterSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]
    private StoveCounter stoveCounter;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        stoveCounter.OnStateChange += StoveCounter_OnStateChange;
    }

    private void StoveCounter_OnStateChange(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        bool playSound = e.state == StoveCounter.State.Fried || e.state == StoveCounter.State.Frying;
        if (playSound)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
}
