using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] levelMusicArray;

    private AudioSource myAudioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy: " + name);
    }

	void Start ()
	{
	    myAudioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level)
	{
	    AudioClip thisLevelMusic = levelMusicArray[level];

		Debug.Log("Playing audio clip: " + levelMusicArray[level]);

        if (thisLevelMusic)
        {
            myAudioSource.clip = thisLevelMusic;
            myAudioSource.loop = true;
            myAudioSource.Play();
        }
	}
}
