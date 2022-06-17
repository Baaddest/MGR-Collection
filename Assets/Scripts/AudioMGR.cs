using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMGR : MonoBehaviour
{
    public GameObject[] AudioObjs;
    public AudioSource CurrentAS;
    public float audiolevel;
    public Slider audioSlider;

    void Start()
    {
        AudioObjs = GameObject.FindGameObjectsWithTag("Audio");
        audiolevel = PlayerPrefs.GetFloat("music", 1);
        foreach (GameObject AS in AudioObjs)
        {
            CurrentAS = AS.GetComponent<AudioSource>();
            CurrentAS.volume = audiolevel;
        }
    }


    void AudioChanged()
    {
        PlayerPrefs.SetFloat("music", audioSlider.value);
        audiolevel = audioSlider.value;
        foreach (GameObject AS in AudioObjs)
        {
            CurrentAS = AS.GetComponent<AudioSource>();
            CurrentAS.volume = audiolevel;
        }
    }
    void Mute()
    {
        foreach (GameObject AS in AudioObjs)
        {
            CurrentAS = AS.GetComponent<AudioSource>();
            CurrentAS.volume = 0;
        }
    }
    void UnMute()
    {
        foreach (GameObject AS in AudioObjs)
        {
            CurrentAS = AS.GetComponent<AudioSource>();
            CurrentAS.volume = audiolevel;
        }
    }
}
