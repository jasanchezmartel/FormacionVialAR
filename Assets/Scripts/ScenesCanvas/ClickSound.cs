using UnityEngine;

public class ClickSound : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip clip;

    public void Play() {
        audioSource.PlayOneShot(clip);
    }
}