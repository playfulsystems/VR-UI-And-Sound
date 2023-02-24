using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    int collisionPoints;

    // play once on collision
    private void OnCollisionEnter(Collision collision)
    {
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.volume = 1;
        audioSource.Play();
        collisionPoints = 0;
    }

    // play on each collision point
    private void OnCollisionStay(Collision collision)
    {
        // all contacts in a collision = collision.contacts
        if (collision.contacts.Length > collisionPoints)
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.volume *= 0.75f;
            audioSource.Play();
        }
        collisionPoints = collision.contacts.Length;

    }
}
