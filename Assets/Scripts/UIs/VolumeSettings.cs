using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

/// <summary>
/// Manages the audio volume settings for music and VFX in the game.
/// Provides functionality to adjust, mute, and unmute audio levels, and saves the settings persistently.
/// Integrates with SaveManager for data storage and AudioMixer for real-time audio adjustments.
/// </summary>
public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer m_myMixer;
    [SerializeField] private Slider m_musicSlider;
    [SerializeField] private Slider m_vfxSlider;

    private float m_previousMusicVolume;
    private float m_previousVFXVolume;
}
