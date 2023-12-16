using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XEntity.InventoryItemSystem;

[RequireComponent(typeof(AudioSource))]
public class SoundSurce : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private List<CLip> _audioClips;

    public void Play(string soundName)
    {
        _audioSource.PlayOneShot(_audioClips.First((i) =>
        {
            return i.Name == soundName;
        }).AudioClip);
    }
}

[Serializable]
public class CLip
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public AudioClip AudioClip { get; private set; }
}


