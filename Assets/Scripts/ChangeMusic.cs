using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    private static ChangeMusic _instance;
    static AudioSource audioSource;

    public static ChangeMusic Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ChangeMusic>();
                if (_instance == null)
                {
                    Debug.LogError("ChangeMusic script not found on any object in scene.");
                }
            }
            return _instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        _instance = this;
    }

    public static void ChangeAudioClip(AudioClip newClip)
    {
        Debug.Log(newClip);
        audioSource.clip = newClip;
        audioSource.Play();

    }
    public static void StopMusic()
    {
        audioSource.Stop();
    }

    public static void PlayArrivalSound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
        Debug.Log(audioSource.clip);
    }
}
