using UnityEngine;
using UnityEngine.Audio;

public class SettingsPanel : Panel
{
    [SerializeField] private AudioMixerGroup _mixer;

    public void ToogleMusic(bool enabled)
    {
        if (enabled)
            _mixer.audioMixer.SetFloat("MusicVolume", 0);
        else
            _mixer.audioMixer.SetFloat("MusicVolume", -80);
    }
    public override void Open()
    {
        base.Open();
        gameObject.GetComponent<Animator>().SetTrigger("Open");
    }
    public void ChangeVolume(float volume) => _mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
}
