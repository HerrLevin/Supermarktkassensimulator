using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kasse : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource == null)
        {
            Debug.Log("The AudioSource is null!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScannableItem"))
        {
            _audioSource.Play();
        }
    }
}
