using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voiceover : MonoBehaviour
{
    public GameObject voiceoverUI;
    public GameObject voiceoverAudio;

    void Start()
    {
        voiceoverUI.SetActive(false);
        voiceoverAudio.SetActive(false);

        StartCoroutine(VoiceDelay());
    }

    IEnumerator VoiceDelay()
    {
        yield return new WaitForSeconds(5f);

        voiceoverUI.SetActive(true);
        voiceoverAudio.SetActive(true);
    }
}
