using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBall : MonoBehaviour
{
    public AudioClip ScoreAudio;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            audioSource.PlayOneShot(ScoreAudio);
        }
    }
}
