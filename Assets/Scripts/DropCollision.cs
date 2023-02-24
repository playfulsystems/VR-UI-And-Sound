using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollision : MonoBehaviour
{
    AudioSource collisionAudioSource;

    private void Awake()
    {
        collisionAudioSource = GetComponent<AudioSource>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        collisionAudioSource.pitch = Random.Range(0.8f, 1.2f);
        collisionAudioSource.Play();
        Destroy(gameObject, 1f);

    }
}
