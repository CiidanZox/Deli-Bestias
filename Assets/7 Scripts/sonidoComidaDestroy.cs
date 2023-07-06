using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoComidaDestroy : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonidoMoneda;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sonidoMoneda, gameObject.transform.position);
        }
    }
}
