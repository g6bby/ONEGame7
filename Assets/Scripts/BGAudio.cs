using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAudio : MonoBehaviour
{

AudioSource audioSource;

void Start()
{
    audioSource = GetComponent<AudioSource>();
    audioSource.Play();
}


void Awake()
{
    DontDestroyOnLoad(this.gameObject);
}


}
