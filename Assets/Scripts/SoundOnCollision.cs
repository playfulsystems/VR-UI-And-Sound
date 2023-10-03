using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    int collisionPointsPlayed;

    // play once on collision
    private void OnCollisionEnter(Collision collision)
    {
        if (Time.time > 0.5f)
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.volume = 1;
            audioSource.Play();
            collisionPointsPlayed = 1;
        }
    }

    // play on each collision point
    private void OnCollisionStay(Collision collision)
    {
        // all contacts in a collision = collision.contacts
        if (collision.contacts.Length > collisionPointsPlayed && Time.time > 0.5f)
        {
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.volume *= 0.75f;
            audioSource.Play();
            collisionPointsPlayed++;
        }
    }
}
