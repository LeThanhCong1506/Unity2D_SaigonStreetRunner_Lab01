using UnityEngine;

/// <summary>
/// Manages saving and loading of game data using PlayerPrefs.
/// Provides methods to save and retrieve high scores, volume settings, and other game-related data.
/// Ensures data persistence across game sessions.
/// </summary>
public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; private set; }

    private const string HighScoreKey = "HighScore";
    private const string MusicVolumeKey = "MusicVolume";
    private const string VFXVolumeKey = "VFXVolume";
    private const string PreviousMusicVolumeKey = "PreviousMusicVolume";
    private const string PreviousVFXVolumeKey = "PreviousVFXVolume";
}
