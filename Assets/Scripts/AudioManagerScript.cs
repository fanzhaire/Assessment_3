using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioClip gameintro;  // 修改变量名
    public AudioClip ghostsnormalstate;  // 修改变量名
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayIntro()
    {
        if (audioSource != null && gameintro != null) 
        {
            audioSource.clip = gameintro;  
            audioSource.Play();
            Invoke("PlayNormalState", gameintro.length);  
        }
        else
        {
            Debug.LogError("Audio source or game intro clip is not set");
        }
    }

    private void PlayNormalState()
    {
        if (audioSource != null && ghostsnormalstate != null)  
        {
            audioSource.clip = ghostsnormalstate;  
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio source or ghosts normal state clip is not set");
        }
    }
}

