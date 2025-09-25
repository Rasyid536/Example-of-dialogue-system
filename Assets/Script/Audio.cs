using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour
{

    public AudioSource audioSource;
    public Dialogue dialogue;
    public int[] playAudio;
    public AudioClip Run, Doomed, Chaos, Msc;
    
    void Update()
    {


        
        if(playAudio[dialogue.index] == 0 )
        {
            audioSource.clip = Msc;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        if(playAudio[dialogue.index] == 1 )
        {
            audioSource.clip = Run;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        if(playAudio[dialogue.index] == 2)
        {
            audioSource.clip = Doomed;
            {
                if(!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
        }

        if(playAudio[dialogue.index] == 3)
        {
            audioSource.clip = Chaos;
            {
                if(!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
        }
        if(playAudio[dialogue.index] == 4 )
        {
            audioSource.Stop();
        }
        if(playAudio[dialogue.index] == 5)
        {
            StartCoroutine(FadeIn(1f));
        }
        if(playAudio[dialogue.index] == 6)
        {
            StartCoroutine(FadeOut(1f));
        }
        
    }


    IEnumerator FadeOut(float duration)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / duration;
            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume; // Reset volume setelah fade out
    }

    IEnumerator FadeIn(float duration)
    {
        float targetVolume = 1.0f; // Atur volume akhir yang diinginkan
        audioSource.volume = 0;
        audioSource.Play();

        while (audioSource.volume < targetVolume)
        {
            audioSource.volume += Time.deltaTime / duration;
            yield return null;
        }
    }

}
