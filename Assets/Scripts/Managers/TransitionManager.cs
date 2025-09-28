using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages scene transitions, including starting the game, handling tutorial windows,
/// and playing button sounds. Integrates with SaveManager and AudioManager for state persistence and audio feedback.
/// </summary>
public class TransitionManager : MonoBehaviour
{
    [SerializeField] private GameObject m_tutorialWindow;
    [SerializeField] private GameObject m_backGround;
    [SerializeField] private GameObject m_backGround1;
}
