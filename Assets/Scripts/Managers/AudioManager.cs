using UnityEngine;

/// <summary>
/// Manages all audio-related functionality in the game, including background music,
/// sound effects, and button click sounds. Ensures a singleton instance for global access.
/// </summary>
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip[] BackgroundMenuGame;
    public AudioClip[] BackgroundGameSound;
    public AudioClip ButtonSound;
    public AudioClip Jump;
    public AudioClip Bend_Down;
    public AudioClip Hit_SpeedUp;
    public AudioClip Hit_Coin;
    public AudioClip Death;
}
